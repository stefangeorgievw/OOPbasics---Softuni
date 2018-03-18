using System;
using System.Collections.Generic;
using System.Text;


public interface ICommando : ISpecialisedSoldier
{
    IReadOnlyCollection<Mission> Missions { get; }

    void AddMission(Mission mission);
    void CompleteMission(string missionCodeName);
}


