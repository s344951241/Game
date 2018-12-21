
using GameFramework.Event;
using System;

namespace Game
{
    [XLua.LuaCallCSharp]
    public sealed class LuaEventArgs : GameEventArgs
    {

        public static readonly int EventId = typeof(LuaEventArgs).GetHashCode();
        public override int Id
        {
            get
            {
                return EventId;
            }
        }
        /// <summary>
        /// 事件类型
        /// </summary>
        public string EventType
        {
            get;
            private set;
        }
        /// <summary>
        /// 数据数组长度
        /// </summary>
        private static int _dataLength = 10;
        /// <summary>
        /// 字符串型数据数组
        /// </summary>
        public string[] StringArgs = new string[_dataLength];
        /// <summary>
        /// 整型数据数组
        /// </summary>
        public int[] IntArgs = new int[_dataLength];
        /// <summary>
        /// Lua数据（Table）
        /// </summary>
        public object LuaData;
        public override void Clear()
        {
            Array.Clear(IntArgs, 0, _dataLength);
            Array.Clear(StringArgs, 0, _dataLength);
            LuaData = default(object);
        }
        /// <summary>
        /// 填充
        /// </summary>
        /// <param name="eventType">事件类型</param>
        /// <returns>通用事件</returns>
        public LuaEventArgs Fill(string eventType, object luaData = null)
        {
            EventType = eventType;
            LuaData = luaData;

            return this;
        }
    }
}
