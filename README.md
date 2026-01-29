# USharpVideoLive
A basic video player made for VRChat using Udon and UdonSharp. Supports normal videos and live streams.

![image](https://github.com/user-attachments/assets/62197752-7130-4469-a7ac-0eb62ff8af97)

### See the [Wiki](https://github.com/MerlinVR/USharpVideo/wiki) for more info on advanced configuration and tips + guides

## Features
- Allows master only/everyone lock toggle for video playing
- Video seeking and duration info
- Pause/Play
- Loop video button
- Shows master and the last person to play a video
- Default playlist that plays when entering the world
- Stream player
- Support for YouTube timestamped URL's (youtube.com?v=\<video\>&t=\<seconds\>)
- Volume slider
- Reload button
- Resync button for video synchronization
- Minimal UI option for guests
- Supports YouTube link resolution in the editor the same as in VRC

## Installation
1. Install the latest VRCSDK and latest release of UdonSharp using the [VRChat Creator Companion](https://vrchat.com/home/download)
2. Install the [latest](https://github.com/MerlinVR/USharpVideo/releases/latest) release
2. Drag the USharpVideo prefab into your scene, resize to fit
3. Optionally bake realtime GI for the scene

There is also an example scene with the video player setup with lightmapping and everything in the `USharpVideo/Examples` directory.

## FAQ
### Does YouTube work on Quest?
Yes, YouTube is supported on Quest by default by VRChat now.
