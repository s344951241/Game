using GameFramework.Event;
using System.Collections.Generic;

namespace Game
{
    public sealed class ShowUIGroupEventArgs : GameEventArgs
    {
        /// <summary>
        /// Id
        /// </summary>
        public static readonly int EventId = typeof(ShowUIGroupEventArgs).GetHashCode();

        /// <summary>
        /// 事件Id
        /// </summary>
        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        private readonly List<string> m_UIGroupNames = new List<string>();

        public List<string> UIGroupNames
        {
            get
            {
                return m_UIGroupNames;
            }
        }

        public enum ShowUIGroupMode
        {
            Inclusive,
            Exclusive
        }

        public ShowUIGroupMode Mode
        {
            private set;
            get;
        }

        public override void Clear()
        {
            Mode = ShowUIGroupMode.Inclusive;
            m_UIGroupNames.Clear();
        }

        public ShowUIGroupEventArgs Fill(ShowUIGroupMode mode, params string[] groupNames)
        {
            Mode = mode;

            foreach (string groupName in groupNames)
            {
                m_UIGroupNames.Add(groupName);
            }
            return this;
        }
    }
}
