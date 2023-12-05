using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sheep : IComparable, IEnumerable
{
    public DateOnly BirthDate { get; init; }
    public static readonly int MaxLife = 25;
    public static int GetMaxLife() => MaxLife;
    public List<AnimalEnvironment> environments;
    public static string Name;
    public List<SheepParameter> SheepParameters;
    int IComparable.CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
