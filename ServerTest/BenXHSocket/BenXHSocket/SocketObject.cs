/*****************************************************
 * ProjectName:  BenXHSocket
 * Description:
 * ClassName:    SocketObject
 * CLRVersion:   4.0.30319.18408
 * Author:       JiYF
 * NameSpace:    BenXHSocket
 * MachineName:  JIYONGFEI
 * CreateTime:   2017/3/31 12:13:06
 * UpdatedTime:  2017/3/31 12:13:06
*****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace BenXHSocket
{
    /// <summary>
    /// Socket基础类
    /// </summary>
    public abstract class SocketObject
    {
        /// <summary>
        /// 初始化Socket方法
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="port"></param>
        public abstract void InitSocket(IPAddress ipAddress,int port);
        public abstract void InitSocket(string ipAddress,int port);

        /// <summary>
        /// Socket启动方法
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Sockdet停止方法
        /// </summary>
        public abstract void Stop();

    }
}
