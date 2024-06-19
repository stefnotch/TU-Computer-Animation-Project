using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

/// <summary>
/// AnimateExitDoorMaterial Script.
/// </summary>
public class AnimateExitDoorMaterial : Script
{
    public float Time = 0.0f;
    public List<MaterialBase> Materials = new List<MaterialBase>();
    private List<MaterialParameter> _parameters = new List<MaterialParameter>();

    /// <inheritdoc/>
    public override void OnEnable()
    {
        foreach (var material in Materials)
        {
            var parameter = material.GetParameter("Time");
            if (parameter)
            {
                _parameters.Add(parameter);
            }
        }
    }

    /// <inheritdoc/>
    public override void OnDisable()
    {
        _parameters.Clear();
    }

    /// <inheritdoc/>
    public override void OnUpdate()
    {
        foreach (var parameter in _parameters)
        {
            parameter.Value = Time;
        }
    }
}
