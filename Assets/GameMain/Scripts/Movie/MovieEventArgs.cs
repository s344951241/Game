using GameFramework.Event;

namespace Game
{
    public sealed class MovieEventArgs : GameEventArgs
    {
        /// <summary>
        /// 视频事件编号。
        /// </summary>
        public static readonly int EventId = typeof(MovieEventArgs).GetHashCode();

        /// <summary>
        /// 获取视频事件编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        /// <summary>
        /// 获取用户自定义数据。
        /// </summary>
        public object UserData
        {
            get;
            private set;
        }

        /// <summary>
        /// 事件類型，VideoPlayer事件名
        /// </summary>
        public string EventType
        {
            get;
            private set;
        }

        /// <summary>
        /// 清理视频事件。
        /// </summary>
        public override void Clear()
        {
            UserData = default(object);
            EventType = default(string);
        }

        /// <summary>
        /// 填充视频事件。
        /// </summary>
        /// <param name="userData">用户自定义数据。</param>
        /// <param name="eventType">VideoPlayer事件名</param>
        /// <returns>视频事件。</returns>
        public MovieEventArgs Fill(object userData, string eventType)
        {
            UserData = userData;
            EventType = eventType;

            return this;
        }
    }
}
