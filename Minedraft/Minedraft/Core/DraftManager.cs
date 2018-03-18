using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string mode;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private Dictionary<string, Harvester> harvesters = new Dictionary<string, Harvester>();
    private Dictionary<string, Provider> providers=  new Dictionary<string, Provider>();

    public DraftManager()
    {
        this.mode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        string msg = string.Empty;
        var type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyRequirement = double.Parse(arguments[3]);
        try
        {
            if (type == "Hammer")
            {
                harvesters.Add(id, new HammerHarvester(id, oreOutput, energyRequirement));
                msg = $"Successfully registered {type} Harvester - {id}";

            }
            else
            {
                int sonicFactor = int.Parse(arguments[4]);
                harvesters.Add(id, new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor));
                msg = $"Successfully registered {type} Harvester - {id}";
            }
        }
        catch (Exception ex)
        {

            msg = ex.Message;
        }
        return msg;
        
    }

    public string RegisterProvider(List<string> arguments)
    {
        string msg;
        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);
        try
        {
            if (type == "Solar")
            {
                providers.Add(id, new SolarProvider(id, energyOutput));
                msg = $"Successfully registered {type} Provider - {id}";
            }
            else
            {
                providers.Add(id, new PressureProvider(id, energyOutput));
                msg = $"Successfully registered {type} Provider - {id}";
            }
        }
        catch (Exception ex)
        {

            msg = ex.Message;
        }
        return msg;
        
    }

    public string Day()
    {
        double dayEnergy = 0;
        double dayOre = 0;
        double harvestNeededEnergyForDay = 0;

        dayEnergy = providers.Sum(p => p.Value.EnergyOutput);
        totalStoredEnergy += dayEnergy;

        harvestNeededEnergyForDay = harvesters.Sum(h => h.Value.EnergyRequirement);
        if (totalStoredEnergy >= harvestNeededEnergyForDay)
        {
            if (mode == "Full")
            {
                dayOre = harvesters.Sum(x => x.Value.OreOutput);
                totalStoredEnergy -= harvestNeededEnergyForDay;
            }
            else if (mode == "Half")
            {
                dayOre += harvesters.Values.Sum(h => (h.OreOutput * 50) / 100);
                totalStoredEnergy -= (harvestNeededEnergyForDay * 60) / 100;
            }
            totalMinedOre += dayOre;
        }

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {dayEnergy}");
        sb.AppendLine($"Plumbus Ore Mined: {dayOre}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        string nextMode = arguments[0];
        mode = nextMode;
        var msg = $"Successfully changed working mode to {mode} Mode";
        return msg;
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        if (harvesters.ContainsKey(id))
        {
            return harvesters[id].ToString();
        }
        else if (providers.ContainsKey(id))
        {
            return providers[id].ToString();
        }
        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

        return sb.ToString().Trim();
    }
}

