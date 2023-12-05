using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SheepParameter
{
    public HealthParameter<int> TimeToStand = new HealthParameter<int>()
    {
        //به صورت ساعت محاسبه می شود
        Name = "TimeToStand",
        Current = 7,
        Standard = 10
    };
    public HealthParameter<int> TimeToDeal = new HealthParameter<int>()
    {
        //به صورت ساعت محاسبه می شود
        Name = "TimeToDeal",
        Current = 7,
        Standard = 10
    };
    public HealthParameter<int> TimeToRelax = new HealthParameter<int>()
    {
        //به صورت ساعت محاسبه می شود
        Name = "TimeToRelax",
        Current = 4,
        Standard = 4
    };
    public HealthParameter<int> NumberOfMeal = new HealthParameter<int>()
    {
        //به صورت تعداد وعده محاسبه می شود
        Name = "NumberOfMeal",
        Current = 3,
        Standard = 4
    };
    public HealthParameter<int> NumberOfMilkProduction = new HealthParameter<int>()
    {
        //به صورت لیتر محاسبه می شود
        Name = "NumberOfMilkProduction",
        Current = 70,
        Standard = 84
    };
    public DateOnly date = new DateOnly();
    public override string ToString()
    {
        var tstring = $"Stand Time:{TimeToStand} TimeToDeal{TimeToDeal} TimeToRelax {TimeToRelax} NumberOfMeal {NumberOfMeal} NumberOfMilkProduction {NumberOfMilkProduction} {date}";
        return tstring.ToString();
    }
}
