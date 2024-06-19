using FlaxEngine;

namespace Game;

/// <summary>
/// Attach this script to the parent of the camera to make it bob up and down as the player moves.
/// </summary>
public class CameraBobbing : Script
{
    public float WalkSpeed = 300.0f;
    private float _time;
    public Camera TargetCamera;
    private Vector3 _lastPosition;
    /// <inheritdoc/>
    public override void OnStart()
    {
        if (TargetCamera)
        {
            Camera.OverrideMainCamera = TargetCamera;
        }
    }

    /// <inheritdoc/>
    public override void OnEnable()
    {
        // Here you can add code that needs to be called when script is enabled (eg. register for events)
        _lastPosition = TargetCamera.LocalPosition;
        _time = 0.0f;
    }

    /// <inheritdoc/>
    public override void OnDisable()
    {
        // Here you can add code that needs to be called when script is disabled (eg. unregister from events)
    }

    /// <inheritdoc/>
    public override void OnUpdate()
    {
        var delta = TargetCamera.LocalPosition - _lastPosition;
        _lastPosition = TargetCamera.LocalPosition;
        var speed = delta.Length / Time.DeltaTime;

        var speedFraction = Mathf.Min(speed / Mathf.Max(WalkSpeed, 0.01f), 100f);
        _time += Time.DeltaTime * speedFraction;

        var offset = new Vector3(
            Mathf.Sin(_time * 5.0f) * 0.5f,
            Mathf.Sin(_time * 3.0f) * 0.4f,
            Mathf.Sin(_time * 1.0f) * 0.2f
        ) * speedFraction;
        Actor.LocalEulerAngles = offset;
    }
}
