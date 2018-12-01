using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public partial class GameEntry
    {
        public static SystemInfoComponent SystemInfo
        {
            get;
            private set;
        }
        public static QualityComponent Quality
        {
            get;
            private set;
        }
        public static MovieComponent Movie
        {
            get;
            private set;
        }
        public static BuiltinDataComponent BuiltinData
        {
            get;
            private set;
        }
        //public static DataCacheComponent DataCache
        //{
        //    get;
        //    private set;
        //}
        //public static CameraComponent Camera
        //{
        //    get;
        //    private set;
        //}



        //public static InputComponent Input
        //{
        //    get;
        //    private set;
        //}

        //public static LogComponent Log
        //{
        //    get;
        //    private set;
        //}

        public static LuaComponent Lua
        {
            get;
            private set;
        }

        //public static ShaderComponent Shader
        //{
        //    get;
        //    private set;
        //}
        public static TableComponent Table
        {
            get;
            private set;
        }
        private static void InitCustomComponents()
        {
            SystemInfo = UnityGameFramework.Runtime.GameEntry.GetComponent<SystemInfoComponent>();
            Quality = UnityGameFramework.Runtime.GameEntry.GetComponent<QualityComponent>();
            Movie = UnityGameFramework.Runtime.GameEntry.GetComponent<MovieComponent>();
            BuiltinData = UnityGameFramework.Runtime.GameEntry.GetComponent<BuiltinDataComponent>();
            Table = UnityGameFramework.Runtime.GameEntry.GetComponent<TableComponent>();
            Lua = UnityGameFramework.Runtime.GameEntry.GetComponent<LuaComponent>();
            //DataCache = UnityGameFramework.Runtime.GameEntry.GetComponent<DataCacheComponent>();
        }
    }
}
