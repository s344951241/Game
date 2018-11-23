using GameFramework;
using GameFramework.Resource;
using UnityEngine;
using UnityEngine.Video;
using UnityGameFramework.Runtime;

namespace Game
{
    [DisallowMultipleComponent]
    public class MovieComponent : GameFrameworkComponent
    {
        [SerializeField]
        private VideoPlayer m_VideoPlayer = null;

        [SerializeField]
        public bool m_RegisterToGF = false;

        private object m_UserData = null;

        private bool m_CanSkip = false;

        private LoadAssetCallbacks m_LoadAssetCallbacks = null;

        private AudioSource m_AudioSource = null;

        private bool m_Prepared = false;

        private bool m_WaitingPlay = false;

        /// <summary>
        /// 播放视频(屏幕)
        /// </summary>
        /// <param name="id">視頻ID(Movie.txt)</param>
        /// <param name="userData">自定義數據</param>wat
        /// <remarks> “是否可跳过”由数据表决定</remarks>
        public void PlayOnScreen(int id, object userData)
        {
            //var excel = GameEntry.DataTable.GetDataTable<DRMovie>();
            //var row = excel.GetDataRow(id);
            //if (row == null)
            //{
            //    Log.Error(string.Format("Movie({0}:{1}).user PlayOnScreen(no {2} in Movie.txt)", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name, id));
            //    GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "errorReceived"));
            //    return;
            //}

            //PlayOnScreen(row.AssetName, row.CanSkip, userData);
        }

        /// <summary>
        /// 播放视频(屏幕)
        /// </summary>
        /// <param name="assetName">视频資源路徑</param>
        /// <param name="canSkip">是否可以跳过</param>
        /// <param name="userData">自定義數據</param>
        public void PlayOnScreen(string assetName, bool canSkip, object userData)
        {
            // PLog.Debug(Programmer.SunXiqiang, string.Format("Movie({0}:{1}).user PlayOnScreen({2})", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name, assetName));
            m_VideoPlayer.renderMode = VideoRenderMode.CameraFarPlane;
            ShowFullScreenCamera(true);
            m_CanSkip = canSkip;
            m_UserData = userData;
            GameEntry.Resource.LoadAsset(assetName, Constant.AssetPriority.MovieAsset, m_LoadAssetCallbacks);
        }

        /// <summary>
        /// 播放视频(屏幕)
        /// </summary>
        /// <param name="videoClip">视频源</param>
        /// <param name="canSkip">是否可以跳过</param>
        /// <param name="userData">自定義數據</param>
        public void PlayOnScreen(VideoClip videoClip, bool canSkip, object userData)
        {
            //PLog.Debug(Programmer.SunXiqiang, string.Format("Movie({0}:{1}).user PlayOnScreen({2})", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name, videoClip));
            m_VideoPlayer.renderMode = VideoRenderMode.CameraFarPlane;
            ShowFullScreenCamera(true);
            m_CanSkip = canSkip;
            m_UserData = userData;
            Prepare(videoClip);
        }

        /// <summary>
        /// 播放视频(貼圖)
        /// </summary>
        /// <param name="id">視頻ID(Movie.txt)</param>
        /// <param name="renderTexture">目標貼圖</param>
        /// <param name="userData">自定義數據</param>
        /// <remarks> 在貼圖上播放時，默認不允許跳過</remarks>
        public void PlayOnTexture(int id, RenderTexture renderTexture, object userData)
        {
            //PLog.Debug(Programmer.SunXiqiang, string.Format("Movie({0}:{1}).user PlayOnTexture({2})", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name, id));
            //var excel = GameEntry.DataTable.GetDataTable<DRMovie>();
            //var row = excel.GetDataRow(id);
            //if (row == null)
            //{
            //    Log.Error(string.Format("Movie({0}:{1}).user PlayOnTexture(no {2} in Movie.txt)", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name, id));
            //    GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "errorReceived"));
            //    return;
            //}

            //PlayOnTexture(row.AssetName, renderTexture, userData);
        }

        /// <summary>
        /// 播放视频(貼圖)
        /// </summary>
        /// <param name="assetName">视频資源路徑</param>
        /// <param name="renderTexture">目標貼圖</param>
        /// <param name="userData">自定義數據</param>
        /// <remarks> 在貼圖上播放時，默認不允許跳過</remarks>
        public void PlayOnTexture(string assetName, RenderTexture renderTexture, object userData)
        {
            //PLog.Debug(Programmer.SunXiqiang, string.Format("Movie({0}:{1}).user PlayOnTexture({2})", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name, assetName));
            m_VideoPlayer.renderMode = VideoRenderMode.RenderTexture;
            ShowFullScreenCamera(false);
            m_VideoPlayer.targetTexture = renderTexture;
            m_CanSkip = false;
            m_UserData = userData;
            GameEntry.Resource.LoadAsset(assetName, Constant.AssetPriority.MovieAsset, m_LoadAssetCallbacks);
        }

        /// <summary>
        /// 播放视频(貼圖)
        /// </summary>
        /// <param name="videoClip">视频源</param>
        /// <param name="renderTexture">目標貼圖</param>
        /// <param name="userData">自定義數據</param>
        /// <remarks> 在貼圖上播放時，默認不允許跳過</remarks>
        public void PlayOnTexture(VideoClip videoClip, RenderTexture renderTexture, object userData)
        {
            //PLog.Debug(Programmer.SunXiqiang, string.Format("Movie({0}:{1}).user PlayOnTexture({2})", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name, videoClip));
            m_VideoPlayer.renderMode = VideoRenderMode.RenderTexture;
            ShowFullScreenCamera(false);
            m_VideoPlayer.targetTexture = renderTexture;
            m_CanSkip = false;
            m_UserData = userData;
            Prepare(videoClip);
        }

        /// <summary>
        /// 播放视频
        /// </summary>
        /// <param name="videoClip">视频源</param>
        private void Prepare(VideoClip videoClip)
        {
            if (videoClip == null)
            {
                Log.Error(string.Format("Movie({0}:{1}).Prepare(null clip)", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name));
                GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "errorReceived"));
                return;
            }

            m_VideoPlayer.clip = videoClip;
            m_Prepared = false;
            m_WaitingPlay = true;
            m_VideoPlayer.Prepare();
        }

        /// <summary>
        /// 暂停播放
        /// </summary>
        public void Pause()
        {
            
            if (m_Prepared)
                m_VideoPlayer.Pause();
            else
                Log.Warning(string.Format("Movie({0}:{1}).user Pause(not ready)", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name));
        }

        /// <summary>
        /// 继续播放
        /// </summary>
        public void Play()
        {
            
            m_WaitingPlay = true;
            if (m_Prepared)
                m_VideoPlayer.Play();
            else
                Log.Warning(string.Format("Movie({0}:{1}).user Play(not ready)", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name));
        }

        /// <summary>
        /// 停止播放
        /// </summary>
        public void Stop()
        {
            
            m_VideoPlayer.Stop();
            ShowFullScreenCamera(false);
            GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "stopped"));
        }

        /// <summary>
        /// 設置音量
        /// <param name="time">跳到指定时间点（秒）</param>
        /// </summary>
        /// <remarks> 视频必须已经Started</remarks>
        public void Seek(float seconds)
        {
            
            if (m_Prepared)
                m_VideoPlayer.time = seconds;
            else
                Log.Warning(string.Format("Movie({0}:{1}).user Seek(not ready)", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name));
        }

        /// <summary>
        /// 設置音量
        /// <param name="volume">音量（0 - 1）</param>
        /// </summary>
        public void SetVolume(float volume)
        {
            if (m_AudioSource != null)
                m_AudioSource.volume = volume;
            else
                Log.Warning(string.Format("Movie({0}:{1}).user SetVolume(not ready)", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name));
        }

        private void ShowFullScreenCamera(bool value)
        {
            var camera = m_VideoPlayer.targetCamera;
            if (camera)
                camera.gameObject.SetActive(value);
        }

        protected override void Awake()
        {
            if (m_RegisterToGF)
                base.Awake();

            if (m_VideoPlayer == null)
            {
                m_VideoPlayer = gameObject.GetOrAddComponent<VideoPlayer>();
            }

            if (m_AudioSource == null)
            {
                m_AudioSource = gameObject.GetOrAddComponent<AudioSource>();
            }

            m_VideoPlayer.SetTargetAudioSource(0, m_AudioSource);
            m_VideoPlayer.sendFrameReadyEvents = false;

            m_VideoPlayer.started += OnVideoPlayerStarted;
            m_VideoPlayer.prepareCompleted += OnVideoPlayerPrepareCompleted;
            m_VideoPlayer.seekCompleted += OnVideoPlayerSeekCompleted;
            m_VideoPlayer.loopPointReached += OnVideoPlayerLoopPointReached;
            m_VideoPlayer.errorReceived += OnVideoPlayerErrorReceived;

            m_LoadAssetCallbacks = new LoadAssetCallbacks(LoadSuccessCallback, LoadFailureCallback);
        }

        private void OnDestroy()
        {
            m_VideoPlayer.started -= OnVideoPlayerStarted;
            m_VideoPlayer.prepareCompleted -= OnVideoPlayerPrepareCompleted;
            m_VideoPlayer.seekCompleted -= OnVideoPlayerSeekCompleted;
            m_VideoPlayer.loopPointReached -= OnVideoPlayerLoopPointReached;
            m_VideoPlayer.errorReceived -= OnVideoPlayerErrorReceived;
        }

        private void Update()
        {
            if (!m_VideoPlayer.isPlaying)
            {
                return;
            }

            if (m_CanSkip)
            {
                if (Input.touchCount > 0 || Input.GetMouseButton(0))
                {
                    Stop();
                }
            }
        }

        private void OnVideoPlayerStarted(VideoPlayer videoPlayer)
        {
            // 在播放方法调用之后被执行。
           
            GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "started"));
        }

        private void OnVideoPlayerPrepareCompleted(VideoPlayer videoPlayer)
        {
            // 视频准备完成时被执行。
            // 发现Unity2018编辑器暂停并恢复时，会触发视频的prepareCompleted，所以仅首次发生时执行播放
            // 再次发生时要Stop，否则会挡住屏幕（Unity视频旧Bug刚修好又添新的 - -）
            m_Prepared = true;

            if (m_WaitingPlay)
            {
               
                m_VideoPlayer.Play();
                m_WaitingPlay = false;
            }
            else
            {
                
                m_VideoPlayer.Stop();
            }

          
            GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "prepareCompleted"));
        }

        private void OnVideoPlayerSeekCompleted(VideoPlayer videoPlayer)
        {
            // 查询帧操作完成时被执行。
            
            GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "seekCompleted"));
        }

        private void OnVideoPlayerLoopPointReached(VideoPlayer videoPlayer)
        {
            // 播放结束或播放到循环的点时被执行。
           
            GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "loopPointReached"));
            Stop();
        }

        private void OnVideoPlayerErrorReceived(VideoPlayer videoPlayer, string errorMessage)
        {
            // 错误监听到时被执行。
            
            GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "errorReceived"));
        }

        private void LoadSuccessCallback(string assetName, object asset, float duration, object userData)
        {
            Prepare(asset as VideoClip);
        }

        private void LoadFailureCallback(string assetName, LoadResourceStatus status, string errorMessage, object userData)
        {
            Log.Error(string.Format("Movie({0}:{1}).LoadFailureCallback({2})", m_VideoPlayer.GetInstanceID(), m_VideoPlayer.name, assetName));
            GameEntry.Event.Fire(this, ReferencePool.Acquire<MovieEventArgs>().Fill(m_UserData, "errorReceived"));
        }

    }
}
