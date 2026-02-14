using Microsoft.Maui.Graphics;

namespace projektprojekt.Game;

public sealed class Enemy
{
    public required EnemyType Type { get; init; }
    public float Hp { get; set; }
    public float MaxHp { get; init; }

    public float Speed { get; init; } 

    public PointF Position { get; set; }
    public int PathSegmentIndex { get; set; }
    public bool IsDead => Hp <= 0;
    public bool ReachedEnd { get; set; }

    public float Radius { get; init; }
    public int Reward { get; init; }
}

public enum EnemyType
{
    Grunt
}
