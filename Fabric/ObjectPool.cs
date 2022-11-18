using System.Collections.Generic;

class ObjectPool
{
    private int numberOfArchers;

    public List<Archer> archers;
    public ObjectPool()
    {
        archers = new List<Archer>();
        numberOfArchers = 5;
        archers = createArchers(numberOfArchers, archers);
    }

    private List<Archer> createArchers(int numberOfArchers, List<Archer> archers)
    {
        for(int i = 1; i <numberOfArchers; i++)
        {
            Archer tempArcher = new Archer();
            this.archers.Add(tempArcher);
        }
        return archers;
    }

    public List<Archer> GetArchers(List<Archer> archers)
    {
        return archers;
    }
}