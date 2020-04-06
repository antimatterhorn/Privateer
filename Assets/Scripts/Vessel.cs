using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Vessel", menuName = "Vessel")]
public class Vessel : ScriptableObject
{
    public VesselClass vesselClass;
    public Sprite portrait;

    public int baseCost;
    public int baseUpkeep;

    public int baseHealth;
    public int maxHealth;
    public int baseDefense;
    public int maxDefense;
    public int baseSpeed;
    public int maxSpeed;
    public int baseCannons;
    public int maxCannons;

    public int maxCargo;
}

public enum VesselClass
{
    Dhow,
    Sloop,
    Cutter,
    Junk,
    Ketch,
    Brig,
    Xebec,
    EastIndiaman,
    Galleon,
    Clipper,
    ManofWar,
}
