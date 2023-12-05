using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
 class Animal
{ 
    public DateOnly BirthDate { get; init; }
    static readonly int MaxLife = 25;
    static int GetMaxLife() => MaxLife;
    public float Weight;
    public string Gender;
    public string Name;
    public int Age;
    public float StressFactor()
    {
        float stressFactor = 0;
        return stressFactor;
    }
    public int Life()
    {
        int Life = 0; 
        return Life;
    }
    public int TimeToDie()
    {
        int TimeToDie = 0;
        return TimeToDie;
    }
    public float KillPriority()
    {
        float KillPriority = 0;
        return KillPriority;
    }
    public int CostPerDay()
    {
        int costPerDay = 0;
        return costPerDay;
    }
    public  int ValuePerDay()
    {
        int valuePerDay = 0;
        return valuePerDay;
    }
}
