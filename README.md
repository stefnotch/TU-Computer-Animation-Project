# Tetris in H~~eaven~~ell

vvvv
[Video download link here](https://github.com/stefnotch/TU-Computer-Animation-Project/releases/download/v1.0.0/video.mp4)
^^^^

What did I do? I made a short video of a Tetris game in hell. The obvious twist is that the Tetris games are impossible, and even if you do solve them, you just land in hell again. It's a looping video.

No audio though, because ...

## Scene 1 - The Entrance

- Modeled the door in Blender
  - Created a texture in GIMP
  - And used Geometry nodes to spawn the door, tile by tile
- Modeled the text in Blender
- Tweaked PostFx stack to get a nice look
  - Added a custom skybox
  - Implemented edge detection (depth and color)
  - Implemented posterization (using the HSV color space)
- Faded the text in (vertex painting each letter + custom shader + scene animations on a tiny script)
- Animated the doors (scene animation)
- Animated the camera
  - Added a custom script for the walk-bobbing effect. Procedural animation.
- Animated the light bulbs on the sign. (straightforward shader that uses the time)
- Obtained 3D model for the arcade machine. Edited the textures to fit the style.

## Scene 2 - Tetris with Physics

- Created a Tetris piece 3D model
- Create a shader for the background (with a shader fwidth trick to get crisp lines)
- Custom vignette shader, because the built-in one wasn't doing the trick
- Changed the lighting to be more flat
- Modeled the simple scene in the game engine 
- Look up how tetris pieces actually move
- Implement tetris movement and built a simple animation editor for it

## Scene 3 - Shattered Tetris

- Blender fracture
- FlaxEngine physics

## Scene 4 - Totally normal Tetris

- Used splines to deform the tetris pieces

## Scene 5 - The Exit Door

- Got a door from Sketchfab https://sketchfab.com/3d-models/low-poly-fire-exit-083f39278c9e42e18047fbdd67164e81
  - Fixed the door in Blender (the door handle needed remeshing)
- Animated the door fading in (custom shader with a noise node)
- Animated camera path and door opening (scene animation)

## Scene 6 - Looping

- Just reused the text from scene 1

## Finally

- Exported as .png sequence
- Used ffmpeg to convert to .mp4
- Joined the scenes together in a video editor

## Credits

https://sketchfab.com/3d-models/defender-arcade-9e656531a0ea4b6595d2337a4006a552

https://sketchfab.com/3d-models/low-poly-fire-exit-083f39278c9e42e18047fbdd67164e81

https://strategywiki.org/wiki/Tetris/Rotation_systems#Super_rotation_system

Heart image is from
https://easy-peasy.ai/ai-image-generator/images/intricately-rendered-heart-sketch-symbol-of-love-and-affection
under CC BY 4.0
