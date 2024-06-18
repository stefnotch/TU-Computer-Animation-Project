
using System;

public enum Rotation
{
  A,
  B,
  C,
  D
}
static class RotationMethods
{
  public static Rotation RotateRight(this Rotation rotation)
  {
    return rotation switch
    {
      Rotation.A => Rotation.B,
      Rotation.B => Rotation.C,
      Rotation.C => Rotation.D,
      Rotation.D => Rotation.A,
      _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
    };
  }
  public static Rotation RotateLeft(this Rotation rotation)
  {
    return rotation switch
    {
      Rotation.A => Rotation.D,
      Rotation.B => Rotation.A,
      Rotation.C => Rotation.B,
      Rotation.D => Rotation.C,
      _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
    };
  }
  // Reference https://strategywiki.org/wiki/Tetris/Rotation_systems#Super_rotation_system

  public static bool[,] ToTShape(this Rotation rotation)
  {
    var n = false;
    var T = true;
    return rotation switch
    {
      Rotation.A => new bool[3, 3]{
        {n,T,n},
        {T,T,T},
        {n,n,n}
      },
      Rotation.B => new bool[3, 3]{
        {n,T,n},
        {n,T,T},
        {n,T,n}
      },
      Rotation.C => new bool[3, 3]{
        {n,n,n},
        {T,T,T},
        {n,T,n}
      },
      Rotation.D => new bool[3, 3]{
        {n,T,n},
        {T,T,n},
        {n,T,n}
      },
      _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
    };
  }

  public static bool[,] ToJShape(this Rotation rotation)
  {
    var n = false;
    var T = true;
    return rotation switch
    {
      Rotation.A => new bool[3, 3]{
        {T,n,n},
        {T,T,T},
        {n,n,n}
      },
      Rotation.B => new bool[3, 3]{
        {n,T,T},
        {n,T,n},
        {n,T,n}
      },
      Rotation.C => new bool[3, 3]{
        {n,n,n},
        {T,T,T},
        {n,n,T}
      },
      Rotation.D => new bool[3, 3]{
        {n,T,n},
        {n,T,n},
        {T,T,n}
      },
      _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
    };
  }

  public static bool[,] ToLShape(this Rotation rotation)
  {
    var n = false;
    var T = true;
    return rotation switch
    {
      Rotation.A => new bool[3, 3]{
        {n,n,T},
        {T,T,T},
        {n,n,n}
      },
      Rotation.B => new bool[3, 3]{
        {n,T,n},
        {n,T,n},
        {n,T,T}
      },
      Rotation.C => new bool[3, 3]{
        {n,n,n},
        {T,T,T},
        {T,n,n}
      },
      Rotation.D => new bool[3, 3]{
        {T,T,n},
        {n,T,n},
        {n,T,n}
      },
      _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
    };
  }

  public static bool[,] ToSShape(this Rotation rotation)
  {
    var n = false;
    var T = true;
    return rotation switch
    {
      Rotation.A => new bool[3, 3]{
        {n,T,T},
        {T,T,n},
        {n,n,n}
      },
      Rotation.B => new bool[3, 3]{
        {n,T,n},
        {n,T,T},
        {n,n,T}
      },
      Rotation.C => new bool[3, 3]{
        {n,n,n},
        {n,T,T},
        {T,T,n}
      },
      Rotation.D => new bool[3, 3]{
        {T,n,n},
        {T,T,n},
        {n,T,n}
      },
      _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
    };
  }

  public static bool[,] ToZShape(this Rotation rotation)
  {
    var n = false;
    var T = true;
    return rotation switch
    {
      Rotation.A => new bool[3, 3]{
        {T,T,n},
        {n,T,T},
        {n,n,n}
      },
      Rotation.B => new bool[3, 3]{
        {n,n,T},
        {n,T,T},
        {n,T,n}
      },
      Rotation.C => new bool[3, 3]{
        {n,n,n},
        {T,T,n},
        {n,T,T}
      },
      Rotation.D => new bool[3, 3]{
        {n,T,n},
        {T,T,n},
        {T,n,n}
      },
      _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
    };
  }


  public static bool[,] ToIShape(this Rotation rotation)
  {
    var n = false;
    var T = true;
    return rotation switch
    {
      Rotation.A => new bool[4, 4]{
        {n,n,n,n},
        {T,T,T,T},
        {n,n,n,n},
        {n,n,n,n}
      },
      Rotation.B => new bool[4, 4]{
        {n,n,T,n},
        {n,n,T,n},
        {n,n,T,n},
        {n,n,T,n}
      },
      Rotation.C => new bool[4, 4]{
        {n,n,n,n},
        {n,n,n,n},
        {T,T,T,T},
        {n,n,n,n}
      },
      Rotation.D => new bool[4, 4]{
        {n,T,n,n},
        {n,T,n,n},
        {n,T,n,n},
        {n,T,n,n}
      },
      _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
    };
  }

  public static bool[,] ToOShape(this Rotation rotation)
  {
    var T = true;
    return new bool[2, 2]{
      {T,T},
      {T,T}
    };
  }
}
