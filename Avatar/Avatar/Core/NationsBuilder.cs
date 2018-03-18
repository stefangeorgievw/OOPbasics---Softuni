using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    public Dictionary<string, Nation> nations;
    public List<string> warArchive;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>
        {
            {"Air", new Nation() },
            {"Water" ,new Nation() },
            {"Earth", new Nation()  },
            {"Fire", new Nation() }
       };
        this.warArchive = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        int power = int.Parse(benderArgs[2]);
        double secondParameter = double.Parse(benderArgs[3]);
        if (type == "Air")
        {
            nations[type].benders.Add(new AirBender(name, power, secondParameter));
        }
       else if (type == "Water")
        {
            nations[type].benders.Add(new WaterBender(name, power, secondParameter));
        }
       else if (type == "Earth")
        {
            nations[type].benders.Add(new EarthBender(name, power, secondParameter));
        }
        if (type == "Fire")
        {
            nations[type].benders.Add(new FireBender(name, power, secondParameter));
        }



    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        int affinity = int.Parse(monumentArgs[2]);
       
        if (type == "Air")
        {
            nations[type].monuments.Add(new AirMonument(name,affinity));
        }
        else if (type == "Water")
        {
            nations[type].monuments.Add(new WaterMonument(name, affinity));
        }
        else if (type == "Earth")
        {
            nations[type].monuments.Add(new EarthMonument(name, affinity));
        }
        if (type == "Fire")
        {
            nations[type].monuments.Add(new FireMonument(name, affinity));
        }
    }

    public string GetStatus(string nationsType)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");
        sb.Append(this.nations[nationsType]);

        return sb.ToString().TrimEnd();

    }

    public void IssueWar(string nationsType)
    {
        var orderedNations = nations.Values.OrderByDescending(n => n.GetTotalPower()).Skip(1).ToList();
        foreach (var nation in orderedNations)
        {
            nation.Clear();
        }
        this.warArchive.Add($"War {this.warArchive.Count + 1} issued by {nationsType}");
    }

    public string GetWarsRecord()
    {
        return string.Join(Environment.NewLine, this.warArchive);
    }
}

