using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public new string name;
    public Sprite portrait;

    public Nationality nationality;

    public int baseAccuracy;
    public int baseInspiration;
    public int baseInitiative;
    public int baseLuck;

    public bool alive = true;
}

public enum Nationality
{
    England,
    France,
    Ireland,
    Scotland,
    Spain,
    Cuba,
    Russia,
    Netherlands,
    India,
    China,
    Korea,
    Morocco,
}
