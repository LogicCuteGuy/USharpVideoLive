using JetBrains.Annotations;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace UdonSharp.Video
{
    [DefaultExecutionOrder(10)]
    [UdonBehaviourSyncMode(BehaviourSyncMode.NoVariableSync)]
    [AddComponentMenu("Udon Sharp/Video/UI/Video Control Handler Minimal")]
    public class VideoControlHandlerMinimal : VideoControlHandlerBase
    {

#pragma warning disable CS0649
        [Header("Volume")]
        [SerializeField]
        private VolumeController volumeController;
#pragma warning restore CS0649

        private void OnEnable()
        {
            if (volumeController) volumeController.SetControlHandler(this);
        }

        public override void SetVolume(float volume)
        {
            if (volumeController) volumeController.SetVolume(volume);
        }

        public override void SetMuted(bool muted)
        {
            if (volumeController) volumeController.SetMuted(muted);
        }

        public override void OnVolumeSliderChange(float volume)
        {
            targetVideoPlayer.SetVolume(volume);
        }

        public override void OnMutePress(bool muted)
        {
            targetVideoPlayer.SetMuted(muted);
        }

        public void OnReSyncButtonPressed()
        {
            targetVideoPlayer.ForceSyncVideo();
        }

        // Stub methods for compatibility with VideoControlHandlerBase interface
        public override void SetStatusText(string newStatus) { }
        public override void SetPaused(bool paused) { }
        public override void SetLocked(bool locked) { }
        public override void SetLooping(bool looping) { }
        public override void AddURLToHistory(VRCUrl url) { }
        public override void OnVideoPlayerOwnerTransferred() { }
        public override void SetToVideoPlayerMode() { }
        public override void SetToStreamPlayerMode() { }
    }
}
