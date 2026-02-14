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

public sealed class Tower
{
    public required TowerType Type { get; init; }
    public required PointF Position { get; init; }

    public float Range { get; init; }
    public float Damage { get; init; }
    public float FireInterval { get; init; }
    public float CooldownLeft { get; set; }
}

public enum TowerType
{
    BasicArcher
}

public sealed class Projectile
{
    public required PointF Position { get; set; }
    public required PointF Velocity { get; init; }
    public float TimeLeft { get; set; }
}

public sealed class PlacementPad
{
    public required PointF Center { get; init; } 
    public float Size { get; init; }            
    public bool HasTower { get; set; }
}