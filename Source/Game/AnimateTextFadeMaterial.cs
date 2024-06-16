using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

/// <summary>
/// AnimateMaterial Script.
/// </summary>
public class AnimateTextFadeMaterial : Script
{
    public Material Material;
    public int LetterIndex = 0;
    private MaterialParameter _param;

    /// <inheritdoc/>
    public override void OnEnable()
    {
        // Here you can add code that needs to be called when script is enabled (eg. register for events)
        if (Material == null)
        {
            Debug.LogError("Material is not assigned.");
            return;
        }
        _param = Material.GetParameter("LetterIndex");
    }

    /// <inheritdoc/>
    public override void OnUpdate()
    {
        if (_param == null) return;
        _param.Value = LetterIndex;
    }
}
