using System;
using System.Collections.Generic;
using System.Text;

public interface IEngineer : ISpecialisedSoldier
{
    IReadOnlyCollection<Repair> Repairs { get; }

    void AddRapair(Repair repair);
}
