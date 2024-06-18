using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

public enum TetrisPieceType
{
    I,
    J,
    L,
    O,
    S,
    T,
    Z
}

public class TetrisPiece : Script
{
    public TetrisPieceType PieceType = TetrisPieceType.T;
    public Rotation rotation = Rotation.A;
    public Prefab CubePrefab;
    private List<Actor> _cubes = new List<Actor>();

    /// <inheritdoc/>
    public override void OnEnable()
    {
        for (int i = 0; i < 4; i++)
        {
            var cube = PrefabManager.SpawnPrefab(CubePrefab);
            cube.Parent = Actor;
            _cubes.Add(cube);
        }
    }

    public override void OnDisable()
    {
        foreach (var cube in _cubes)
        {
            Destroy(cube);
        }
        _cubes.Clear();
    }

    /// <inheritdoc/>
    public override void OnUpdate()
    {
        DrawPiece();
    }

    public void DrawPiece()
    {
        var shape = PieceType switch
        {
            TetrisPieceType.I => rotation.ToIShape(),
            TetrisPieceType.J => rotation.ToJShape(),
            TetrisPieceType.L => rotation.ToLShape(),
            TetrisPieceType.O => rotation.ToOShape(),
            TetrisPieceType.S => rotation.ToSShape(),
            TetrisPieceType.T => rotation.ToTShape(),
            TetrisPieceType.Z => rotation.ToZShape(),
            _ => throw new ArgumentOutOfRangeException()
        };
        int cubeIndex = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (shape[i, j])
                {
                    _cubes[cubeIndex].LocalPosition = new Vector3(j * 100, -i * 100, 0);
                    cubeIndex++;
                }
            }
        }
    }
}
