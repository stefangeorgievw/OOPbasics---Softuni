using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    public List<Bender> benders;
    public List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public double GetTotalPower()
    {
        var monumentBonus = this.monuments.Sum(m => m.GetAffinity());
        var bendersPower = this.benders.Sum(b => b.GetPower());
        var totalPower = bendersPower + ((bendersPower / 100) * monumentBonus);
        return totalPower;
    }

    public void Clear()
    {
        this.benders.Clear();
        this.monuments.Clear();
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("Benders:");
        if (this.benders.Count != 0)
        {
            builder.AppendLine()
.AppendLine(string.Join(Environment.NewLine, this.benders.Select(b => $"###{b}")));
        }
        else
        {
            builder.AppendLine(" None");
        }
        builder.Append("Monuments:");

        if (this.monuments.Count != 0)
        {
            builder.AppendLine()
                .AppendLine(string.Join(Environment.NewLine, this.monuments.Select(m => $"###{m}")));
        }
        else
        {
            builder.Append(" None");
        }

        return builder.ToString().TrimEnd();
    }
}

