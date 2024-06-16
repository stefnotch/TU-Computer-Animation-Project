using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

/// <summary>
/// FadeInMaterial Script.
/// </summary>
public class FadeInMaterial : Script
{
    public float FadeInValue = 0.0f;
    private MaterialInstance _materialInstance;
    private MaterialParameter _hiddenParameter;
    /// <inheritdoc/>
    public override void OnStart()
    {
        _materialInstance = Actor.As<StaticModel>().CreateAndSetVirtualMaterialInstance(0);
        _hiddenParameter = _materialInstance.GetParameter("Hidden");
    }

    /// <inheritdoc/>
    public override void OnEnable()
    {
        // Here you can add code that needs to be called when script is enabled (eg. register for events)
    }

    /// <inheritdoc/>
    public override void OnDisable()
    {
        // Here you can add code that needs to be called when script is disabled (eg. unregister from events)
    }

    /// <inheritdoc/>
    public override void OnUpdate()
    {
        _hiddenParameter.Value = FadeInValue;
    }
}
