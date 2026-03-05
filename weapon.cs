class Weapon
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int MaximumDamage { get; set; }

    public Weapon(int iD, string name, int maximumDamage)
    {
        ID = iD;
        Name = name;
        MaximumDamage = maximumDamage;
    }
}