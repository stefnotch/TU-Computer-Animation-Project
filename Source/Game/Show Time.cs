using FlaxEngine;

namespace Game;

public class ShowTime : Script
{
    [ShowInEditor]
    public float CurrentTime => Time.GameTime;
}
