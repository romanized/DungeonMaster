public class Player
{
    public string Name { get; set; }
    public int CurrentHitPoints { get; set; }
    public int MaximumHitPoints { get; set; }
    public Weapon CurrentWeapon { get; set; }
    public Location CurrentLocation { get; set; }

    public Player(string name)
    {
        Name = name;
        CurrentHitPoints = 100;
        MaximumHitPoints = 100;
        CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
    }
}