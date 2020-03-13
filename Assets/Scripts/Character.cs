using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public Sprite portrait;
    public Sex sex;

    public Nationality nationality;

    public int baseAccuracy;
    public int baseInspiration;
    public int baseInitiative;
    public int baseInfamy;
    public int baseLuck;

    public bool alive = true;

    public void GetRandomFrom(Nationality _nationality, Sex _sex)
    {
        nationality = _nationality;
        sex = _sex;
        
        Object[] allSprites = Resources.LoadAll($"Portraits/{nationality}/{sex}",typeof(Sprite));
        int j = Random.Range(0, allSprites.Length);
        portrait = (Sprite)allSprites[j];
        
        GenerateRandomStats();

        NameGenerator nameGen = new NameGenerator(nationality,sex);
        name = nameGen.fullName;
    }

    public void GetRandomFrom(Nationality _nationality)
    {
        int s = Random.Range(0, 2);
        sex = s == 1 ? Sex.Female : Sex.Male;
        GetRandomFrom(_nationality, sex);       
    }

    public void GenerateRandomStats()
    {
        baseAccuracy = Random.Range(0, 4);
        baseInspiration = Random.Range(0, 4);
        baseInitiative = Random.Range(0, 4);
        baseInfamy = Random.Range(0, 4);
        baseLuck = Random.Range(0, 4);
    }
}

public enum Sex
{
    Male,
    Female,
}


public enum Nationality
{
    England,
    France,
    Spain,
    Russia,
    Netherlands,
    China,
    Morocco,
    Africa,
}
