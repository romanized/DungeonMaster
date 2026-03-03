public class Player
{
    public string Name { get; set; }
    public int CurrentHealth { get; set; }
    public int MaxHealth { get; set; }
    public int Damage { get; set; }
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }
    public Weapon CurrentWeapon { get; set; }
    public Location CurrentLocation { get; set; }

    public Player(string name)
    {
        Name = name;
        CurrentHealth = 100;
        MaxHealth = 100;
        Damage = 10;
        Gold = 0;
        ExperiencePoints = 0;
        CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
    }
}