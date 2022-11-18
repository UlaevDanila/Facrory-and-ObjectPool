class Archer
{
    private int health;
    private string weapon;
    private Arrow arrow;

    public Archer()
    {
        setHealth(100);
        setWeapon("bow");
        arrow = new Arrow();
    }

    public int getHealth()
    {
        return health;
    }

    public string getWeapon()
    {
        return weapon;
    }

    public void setWeapon(string weapon) 
    {
        this.weapon = weapon;
    }
    public void setHealth(int health)
    {
        this.health = health;
    }
}
