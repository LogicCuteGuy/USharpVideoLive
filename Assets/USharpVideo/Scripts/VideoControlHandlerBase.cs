using JetBrains.Annotations;
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Data;
using VRC.SDKBase;

namespace UdonSharp.Video
{
    /// <summary>
    /// Abstract base class for video control handlers, defining the common interface
    /// </summary>
    public abstract class VideoControlHandlerBase : UdonSharpBehaviour
    {
        /// <summary>
        /// The video player this UI instance controls and pulls info from
        /// </summary>
        [PublicAPI, NotNull]
        public USharpVideoPlayer targetVideoPlayer;

        [Header("Style Colors")]
        public Color redGraphicColor = new Color(0.632f, 0.19f, 0.19f);
        public Color whiteGraphicColor = new Color(0.9433f, 0.9433f, 0.9433f);
        public Color buttonBackgroundColor = new Color(1f, 1f, 1f, 1f);
        public Color buttonActivatedColor = new Color(1f, 1f, 1f, 1f);
        public Color iconInvertedColor = new Color(1f, 1f, 1f, 1f);

        /// <summary>
        /// Only allow the master to own this so we can check master by checking this object's owner
        /// </summary>
        public override bool OnOwnershipRequest(VRCPlayerApi requestingPlayer, VRCPlayerApi requestedOwner)
        {
            return false;
        }

        // Abstract methods that derived classes must implement
        public abstract void SetStatusText(string newStatus);
        public abstract void SetPaused(bool paused);
        public abstract void SetLocked(bool locked);
        public abstract void SetLooping(bool looping);
        public abstract void AddURLToHistory(VRCUrl url);
        public abstract void OnVideoPlayerOwnerTransferred();
        public abstract void SetToVideoPlayerMode();
        public abstract void SetToStreamPlayerMode();
        public abstract void SetVolume(float volume);
        public abstract void SetMuted(bool muted);
        public abstract void OnVolumeSliderChange(float volume);
        public abstract void OnMutePress(bool muted);
    }
}
