using GameFramework;
using GameFramework.Event;
using GameFramework.Network;
using ProtoBuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Game
{
    public class NetworkChannelHelper : INetworkChannelHelper
    {
        private INetworkChannel m_NetworkChannel = null;
        private readonly Dictionary<int, Type> _protoTypeDic = new Dictionary<int, Type>();
        private readonly MemoryStream m_CachedStream = new MemoryStream(1024 * 8);
        public int PacketHeaderLength
        {
            get
            {
                return ProtoPacketHeader.HEADER_SIZE;
            }
        }
      
        /// <summary>
        /// 反序列消息包头。
        /// </summary>
        /// <param name="source">要反序列化的来源流。</param>
        /// <param name="customErrorData">用户自定义错误数据。</param>
        /// <returns></returns>
        public IPacketHeader DeserializePacketHeader(Stream source, out object customErrorData)
        {
            // 注意：此函数并不在主线程调用！
            customErrorData = null;
            ProtoPacketHeader packetHeader = ReferencePool.Acquire<ProtoPacketHeader>();
            //bool retVal = packetHeader.Deserialize(source);
            //if (retVal)
            //{
            //    return packetHeader;
            //}

            //return null;
            return packetHeader;
        }

        public void Initialize(INetworkChannel networkChannel)
        {

            m_NetworkChannel = networkChannel;
            //m_NetworkChannel.SetDefaultHandler(LuaPacketHandler);

            // 反射注册包和包处理函数。
            Type packetBaseType = typeof(ProtoPacket);
            Type packetHandlerBaseType = typeof(ProtoHandler);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                //if (!types[i].IsClass || types[i].IsAbstract)
                //{
                //    continue;
                //}

                //if (packetBaseType.IsAssignableFrom(types[i]))
                //{
                //    ProtoPacket packetBase = (ProtoPacket)Activator.CreateInstance(types[i]);
                //    Type packetType = GetDownwardPacketType(packetBase.Id);
                //    if (packetType != null)
                //    {
                //        Log.Warning("Already exist packet type '{0}', check '{1}' or '{2}'?.", packetBase.Id.ToString(), packetType.Name, packetBase.GetType().Name);
                //        continue;
                //    }

                //    m_DownwardPacketTypes.Add(packetBase.Id, types[i]);
                //}

                if (!types[i].IsAbstract && !types[i].IsInterface && types[i].GetCustomAttributes(typeof(ProtoContractAttribute), false).Length > 0)
                {
                    _protoTypeDic.Add((int)CRC.GetCRC32(types[i].FullName), types[i]);
                }
                else if (types[i].BaseType == packetHandlerBaseType)
                {
                    IPacketHandler packetHandler = (IPacketHandler)Activator.CreateInstance(types[i]);
                    m_NetworkChannel.RegisterHandler(packetHandler);
                }
            }

            GameEntry.Event.Subscribe(UnityGameFramework.Runtime.NetworkConnectedEventArgs.EventId, OnNetworkConnected);
            GameEntry.Event.Subscribe(UnityGameFramework.Runtime.NetworkClosedEventArgs.EventId, OnNetworkClosed);
            GameEntry.Event.Subscribe(UnityGameFramework.Runtime.NetworkMissHeartBeatEventArgs.EventId, OnNetworkMissHeartBeat);
            GameEntry.Event.Subscribe(UnityGameFramework.Runtime.NetworkErrorEventArgs.EventId, OnNetworkError);
            GameEntry.Event.Subscribe(UnityGameFramework.Runtime.NetworkCustomErrorEventArgs.EventId, OnNetworkCustomError);

           
        }
        /// <summary>
        /// 发送心跳消息包。
        /// </summary>
        /// <returns>是否发送心跳消息包成功。</returns>
        public bool SendHeartBeat()
        {
            if (NeedToSendHeartBeat())
            {
                ProtoBuf.Heart heart = new Heart();
                heart.time = 10;

                ProtoPacket packet = ReferencePool.Acquire<ProtoPacket>();
                packet.SetObj=heart;
                m_NetworkChannel.Send(packet);
            }
            return true;
        }
        /// <summary>
        /// 序列化消息包。
        /// </summary>
        /// <typeparam name="T">消息包类型。</typeparam>
        /// <param name="packet">要序列化的消息包。</param>
        /// <param name="destination">要序列化的目标流。</param>
        /// <returns>是否序列化成功。</returns>
        public bool Serialize<T>(T packet, Stream destination) where T : Packet
        {
            ProtoPacket protoPacket = packet as ProtoPacket;
            if (protoPacket == null)
            {
                Log.Warning("Packet is invalid.");
                return false;
            }
            destination = new MemoryStream(ProtoSerialize.SerializeProto(protoPacket.MsgObj));
            ReferencePool.Release(packet);
            return true;
        }
        /// <summary>
        /// 反序列化消息包。
        /// </summary>
        /// <param name="packetHeader">消息包头。</param>
        /// <param name="source">要反序列化的来源流。</param>
        /// <param name="customErrorData">用户自定义错误数据。</param>
        /// <returns>反序列化后的消息包。</returns>
        public Packet DeserializePacket(IPacketHeader packetHeader, Stream source, out object customErrorData)
        {
            throw new System.NotImplementedException();

            //return new Packet();
        }
        public void Shutdown()
        {
            GameEntry.Event.Unsubscribe(UnityGameFramework.Runtime.NetworkConnectedEventArgs.EventId, OnNetworkConnected);
            GameEntry.Event.Unsubscribe(UnityGameFramework.Runtime.NetworkClosedEventArgs.EventId, OnNetworkClosed);
            GameEntry.Event.Unsubscribe(UnityGameFramework.Runtime.NetworkMissHeartBeatEventArgs.EventId, OnNetworkMissHeartBeat);
            GameEntry.Event.Unsubscribe(UnityGameFramework.Runtime.NetworkErrorEventArgs.EventId, OnNetworkError);
            GameEntry.Event.Unsubscribe(UnityGameFramework.Runtime.NetworkCustomErrorEventArgs.EventId, OnNetworkCustomError);

            m_NetworkChannel = null;
        }

        //private Type GetDownwardPacketType(int packetId)
        //{
        //    Type packetType = null;
        //    if (m_DownwardPacketTypes.TryGetValue(packetId, out packetType))
        //    {
        //        return packetType;
        //    }

        //    return null;
        //}
        private bool NeedToSendHeartBeat()
        {
            GameFramework.Procedure.ProcedureBase procedurebase = GameEntry.Procedure.CurrentProcedure;

            if (procedurebase is ProcedureLaunch
                || procedurebase is ProcedureSplash
                || procedurebase is ProcedureCheckVersion
                || procedurebase is ProcedureUpdateResource
                || procedurebase is ProcedurePreload
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //private void LuaPacketHandler(object sender, Packet packet)
        //{
        //    LuaDownwardPacket packetImpl = (LuaDownwardPacket)packet;

        //    LuaTable luaTable = GameEntry.Lua.NewTable();
        //    GameEntry.Lua.DoScript("Packet/LuaPacketFactory", "LuaPacketFactory", luaTable);
        //    luaTable.Set("self", packetImpl);

        //    Action createFunc = null;
        //    luaTable.Get("Create", out createFunc);
        //    if (createFunc != null)
        //    {
        //        createFunc();
        //    }

        //    createFunc = null;
        //    luaTable.Dispose();
        //}

        private void OnNetworkConnected(object sender, GameEventArgs e)
        {
            UnityGameFramework.Runtime.NetworkConnectedEventArgs ne = (UnityGameFramework.Runtime.NetworkConnectedEventArgs)e;
            if (ne.NetworkChannel != m_NetworkChannel)
            {
                return;
            }

            //UpwardPacketHeader.ResetSerialId();
            Log.Info("Network channel '{0}' connected, local address '{1}:{2}', remote address '{3}:{4}'.", ne.NetworkChannel.Name, ne.NetworkChannel.LocalIPAddress, ne.NetworkChannel.LocalPort.ToString(), ne.NetworkChannel.RemoteIPAddress, ne.NetworkChannel.RemotePort.ToString());
        }
        private void OnNetworkClosed(object sender, GameEventArgs e)
        {
            UnityGameFramework.Runtime.NetworkClosedEventArgs ne = (UnityGameFramework.Runtime.NetworkClosedEventArgs)e;
            if (ne.NetworkChannel != m_NetworkChannel)
            {
                return;
            }

            //UpwardPacketHeader.ResetSerialId();
            Log.Info(Utility.Text.Format("Network channel '{0}' closed.", ne.NetworkChannel.Name));
        }

        private void OnNetworkMissHeartBeat(object sender, GameEventArgs e)
        {
            if (!NeedToSendHeartBeat())
            {
                return;
            }

            UnityGameFramework.Runtime.NetworkMissHeartBeatEventArgs ne = (UnityGameFramework.Runtime.NetworkMissHeartBeatEventArgs)e;
            if (ne.NetworkChannel != m_NetworkChannel)
            {
                return;
            }

            Log.Info("Network channel '{0}' miss heart beat '{1}' times.", ne.NetworkChannel.Name, ne.MissCount.ToString());

            if (Application.isEditor || ne.MissCount < 2)
            {
                return;
            }

            Log.Warning("Network channel '{0}' miss heart beat '{1}' times.", ne.NetworkChannel.Name, ne.MissCount.ToString());

            ne.NetworkChannel.Close();
        }
        private void OnNetworkError(object sender, GameEventArgs e)
        {
            UnityGameFramework.Runtime.NetworkErrorEventArgs ne = (UnityGameFramework.Runtime.NetworkErrorEventArgs)e;
            if (ne.NetworkChannel != m_NetworkChannel)
            {
                return;
            }

            Log.Warning("Network channel '{0}' error, error code is '{1}', error message is '{2}'.", ne.NetworkChannel.Name, ne.ErrorCode.ToString(), ne.ErrorMessage);

            ne.NetworkChannel.Close();
        }
        private void OnNetworkCustomError(object sender, GameEventArgs e)
        {
            UnityGameFramework.Runtime.NetworkCustomErrorEventArgs ne = (UnityGameFramework.Runtime.NetworkCustomErrorEventArgs)e;
            if (ne.NetworkChannel != m_NetworkChannel)
            {
                return;
            }

            Log.Warning("Network channel '{0}' custom error, custom error data is '{1}'.", ne.NetworkChannel.Name, ne.CustomErrorData.ToString());
        }
    }
}


