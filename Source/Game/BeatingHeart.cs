using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

/// <summary>
/// BeatingHeart Script.
/// </summary>
public class BeatingHeart : Script
{
    public float BeatScale = 1.2f;
    public float BeatDuration = 0.4f;
    public float BeatPause = 1.0f;
    public float BeatTimeOffset = 0.0f;
    private UIControl _heart;
    /// <inheritdoc/>
    public override void OnStart()
    {
        _heart = Actor.As<UIControl>();
    }

    /// <inheritdoc/>
    public override void OnUpdate()
    {
        var time = Mathf.Max(Time.GameTime - BeatTimeOffset, 0.0f);
        var beatTime = (float)(time % (BeatDuration + BeatPause));

        var beat = beatTime < BeatDuration ? Mathf.Sin(beatTime / BeatDuration * Mathf.Pi) : 0.0f;
        var scale = Mathf.Lerp(1.0f, BeatScale, beat);
        _heart.Control.Scale = new Float2(scale);
    }
}
