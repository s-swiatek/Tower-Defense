using Microsoft.Maui.Graphics;

namespace projektprojekt.Game;


public sealed class GameEngine
{

    public SizeF WorldSize { get; private set; }


    private readonly List<PointF> _pathNormalized = new();
    public IReadOnlyList<PointF> PathPixels => _pathPixels;
    private readonly List<PointF> _pathPixels = new();


    private readonly List<PlacementPad> _pads = new();
    public IReadOnlyList<PlacementPad> Pads => _pads;

    private readonly List<Enemy> _enemies = new();
    public IReadOnlyList<Enemy> Enemies => _enemies;

    private readonly List<Tower> _towers = new();
    public IReadOnlyList<Tower> Towers => _towers;

    private readonly List<Projectile> _projectiles = new();
    public IReadOnlyList<Projectile> Projectiles => _projectiles;
    public event Action? Victory;
    private int _toSpawn;
    private float _spawnEvery;
    private float _spawnTimer;
    private bool _waveFinishedSpawning;
    private bool _victoryFired;

    public void ResetForSingleWave()
    {
        _enemies.Clear();
        _towers.Clear();
        _projectiles.Clear();
        _victoryFired = false;


        _toSpawn = 10;
        _spawnEvery = 0.8f;
        _spawnTimer = 0f;
        _waveFinishedSpawning = false;


        _pathNormalized.Clear();


        _pathNormalized.Add(new PointF(0.50f, 0.10f));
        _pathNormalized.Add(new PointF(0.50f, 0.42f));
        _pathNormalized.Add(new PointF(0.75f, 0.55f));
        _pathNormalized.Add(new PointF(0.25f, 0.68f));
        _pathNormalized.Add(new PointF(0.50f, 0.92f));

        _pads.Clear();
        _pads.Add(new PlacementPad { Center = new PointF(0.28f, 0.50f), Size = 52, HasTower = false });
        _pads.Add(new PlacementPad { Center = new PointF(0.72f, 0.38f), Size = 52, HasTower = false });
        _pads.Add(new PlacementPad { Center = new PointF(0.72f, 0.70f), Size = 52, HasTower = false });
        _pads.Add(new PlacementPad { Center = new PointF(0.28f, 0.78f), Size = 52, HasTower = false });
    }
}
