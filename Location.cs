public class Location
{
    public int ID;
    public string Name;
    public string Description;

    public Location LocationToNorth;
    public Location LocationToSouth;
    public Location LocationToEast;
    public Location LocationToWest;

    public Monster MonsterLivingHere;
    public Quest QuestAvailableHere;

    public Location(int id, string name, string description, Location North, Location South)
    {
        ID = id;
        Name = name;
        Description = description;
        LocationToNorth = North;
        LocationToSouth = South;
    }
}