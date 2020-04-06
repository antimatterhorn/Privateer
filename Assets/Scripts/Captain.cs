using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Captain
{
    public Character character;
    public string name;
    public string title;

    public Ship ship;

    public int level;
    public int exp;

    public Dictionary<string,int> captainTraits;

    public Captain (Character baseCharacter)
    {
        character = baseCharacter;
        name = character.name;

        captainTraits = new Dictionary<string, int>
        {
            { "accuracy",       character.baseAccuracy },
            { "inspiration",    character.baseInspiration },
            { "initiative",     character.baseInitiative },
            { "infamy",         character.baseInfamy },
            { "luck",           character.baseLuck }
        };
        level = 1;
        exp = 0;
    }

    public void AssignToShip(Ship _ship)
    {
        _ship.AssignCaptain(this);
        ship = _ship;
    }

    public void LevelUp()
    {
        int luck = captainTraits["luck"];
        int traitsToLevel = 1 + Mathf.RoundToInt(2f*Random.Range(0f,luck/20f));
        LevelUp(traitsToLevel);
    }

    public void LevelUp(int traitsToLevel)
    {
        level++;
        for (int i = 0; i < traitsToLevel; i++)
        {
            int j = Random.Range(0, captainTraits.Count);
            string trait = captainTraits.Keys.ToList()[j];
            captainTraits[trait]++;
            Debug.Log(string.Format("Leveled {0}", trait));
        }
    }

    public void RenameCaptain(string _name)
    {
        name = _name;
    }
}
