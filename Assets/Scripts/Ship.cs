using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Ship
{
    public Vessel vessel;
    public string name;
    public Dictionary<string, int> shipTraits;

    public Captain captain;
    public Dictionary<string, int> captainTraits;

    public int exp;

    public Ship(Vessel baseVessel)
    {
        vessel = baseVessel;
        // make a name generator

        shipTraits = new Dictionary<string, int>
        {
            { "cost",       vessel.baseCost },
            { "upkeep",     vessel.baseUpkeep },
            { "health",     vessel.baseHealth },
            { "maxHealth",  vessel.maxHealth },
            { "defense",    vessel.baseDefense },
            { "maxDefense", vessel.maxDefense },
            { "speed",      vessel.baseSpeed },
            { "maxSpeed",   vessel.maxSpeed },
            { "cannons",    vessel.baseCannons },
            { "maxCannons", vessel.maxCannons },
            { "maxCargo",   vessel.maxCargo }
        };

        exp = 0;
    }
    
    public void AssignCaptain(Captain _captain)
    {
        captain = _captain;
        captainTraits = captain.captainTraits;
    }

    public void LevelUp()
    {
        int luck = captainTraits["luck"];
        int traitsToLevel = 1 + Mathf.RoundToInt(2f * Random.Range(0f, luck / 20f));

    }

    public void LevelUp(int traitsToLevel)
    {
        for (int i = 0; i < traitsToLevel; i++)
        {
            
        }
    }

    public void RenameShip(string _name)
    {
        name = _name;
    }
}


