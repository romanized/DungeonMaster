public class Monster
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }
    public int MaxHealth { get; set; }
    public int CurrentHealth { get; set; }

    public Monster(int id, string name, int damage, int maxHealth, int currentHealth)
    {
        ID = id;
        Name = name; 
        Damage = damage;
        MaxHealth = maxHealth;
        CurrentHealth = currentHealth;
    }
}