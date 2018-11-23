using GameFramework.Event;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace Game
{
    public class ProcedureSplash : ProcedureBase
    {
        private bool m_SplashMoviePlayFinished = false;

        public override bool UseNativeDialog
        {
            get
            {
                return true;
            }
        }

        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            m_SplashMoviePlayFinished = false;

            GameEntry.Event.Subscribe(MovieEventArgs.EventId, OnMovieEvent);
            GameEntry.Movie.PlayOnScreen(GameEntry.BuiltinData.SplashMovie, GameEntry.BuiltinData.SplashCanSkip, this);
        }

        protected internal override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
            GameEntry.Event.Unsubscribe(MovieEventArgs.EventId, OnMovieEvent);
        }

        protected internal override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            if (m_SplashMoviePlayFinished)
            {
                // 编辑器模式下，直接进入预加载流程；否则，检查版本
                ChangeState(procedureOwner, GameEntry.Base.EditorResourceMode ? typeof(ProcedurePreload) : typeof(ProcedureCheckVersion));
            }
        }

        private void OnMovieEvent(object sender, GameEventArgs e)
        {
            MovieEventArgs ne = (MovieEventArgs)e;
            if (ne.UserData != this)
                return;

            switch (ne.EventType)
            {
                case "stopped":             // go on
                case "loopPointReached":    // go on
                case "errorReceived":
                    m_SplashMoviePlayFinished = true;
                    break;
            }
        }

    }
}
