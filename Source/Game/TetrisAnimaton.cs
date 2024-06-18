using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

public struct TetrisKeyframe
{
    [Range(0, 6)]
    public int X;
    public float Y;
    public Rotation Rotation;
}

/// <summary>
/// TetrisAnimaton Script.
/// </summary>
public class TetrisAnimaton : Script
{
    public TetrisPiece Piece;
    public List<TetrisKeyframe> Keyframes = [];
    /// Set the duration of each frame in seconds
    public float FrameDuration = 0.8f;
    public bool IsLooping = false;

    /// <inheritdoc/>
    public override void OnUpdate()
    {
        if (Keyframes.Count == 0)
        {
            return;
        }

        float FrameTime = Time.GameTime / FrameDuration;
        if (IsLooping)
        {
            FrameTime %= Keyframes.Count;
        }

        var keyframe = Keyframes[Keyframes.Count - 1];
        for (int i = 0; i < Keyframes.Count; i++)
        {
            if (FrameTime < Keyframes[i].Y)
            {
                keyframe = Keyframes[i];
                break;
            }
        }

        Piece.rotation = keyframe.Rotation;
        Piece.Actor.LocalPosition = new Vector3(keyframe.X * 100, -Mathf.Floor(keyframe.Y) * 100, 0);
    }
}
