

using GameFramework.Event;

namespace Game
{
    public class CommonEventArgs : GameEventArgs
    {
        public static readonly int EventId = typeof(CommonEventArgs).GetHashCode();

        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        public string Params
        {
            get;
            private set;
        }

        public override void Clear()
        {
            Params = string.Empty;
        }

        public CommonEventArgs Fill(string str)
        {
            Params = str;
            return this;
        }
    }
}
