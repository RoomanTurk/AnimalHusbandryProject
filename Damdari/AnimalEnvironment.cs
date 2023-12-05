using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class AnimalEnvironment
{
    public HealthParameter<double> TDS = new HealthParameter<double>
    {
        //کل جامدات محلول
        Name = "Total Dissolved Solids",
        Current = 1460,
        Standard = 1500
    };
    public HealthParameter<double> Temp = new HealthParameter<double>
    {
        // دما بر حسب سلسیوس
        Name ="Temp",
        Current = 29.00,
        Standard = 32.00,
    };
    public HealthParameter<double> Density = new HealthParameter<double>
    {
        // تراکم
        Name = "Temp",
        Current = 20.00,
        Standard = 16.00,
    };
    public HealthParameter<double> db = new HealthParameter<double>
    {
        // سر و صدا
        Name = "db",
        Current = 77.00,
        Standard = 65.00,
    };
    public HealthParameter<double> AQI = new HealthParameter<double>
    {
        // شاخص کیفیت هوا
        Name = "Air Quality Index",
        Current = 60.00,
        Standard = 70.00,
    };
    public HealthParameter<double> OX = new HealthParameter<double>
    {
        // اکسیژن
        Name = "Oxygen",
        Current = 29.00,
        Standard = 32.00,
    };
    public DateOnly date = new DateOnly();
}
