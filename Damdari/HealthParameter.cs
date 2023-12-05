using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


public class HealthParameter<T>
{
    public string Name { get; set; }
    public T Current { get; set; }
    public T Standard { get; set; }
    public override string ToString()
    {
        var tstring = Name + Current + Standard;
        return tstring.ToString();
    }
}

