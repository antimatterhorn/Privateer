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

    public int level;

    public Dictionary<string,int> captainTraits;

    public Captain (Character baseCharacter)
    {
        character = baseCharacter;
        name = character.name;

        captainTraits = new Dictionary<string, int>();
        captainTraits.Add("accuracy", character.baseAccuracy);
        captainTraits.Add("inspiration", character.baseInspiration);
        captainTraits.Add("initiative", character.baseInitiative);
        captainTraits.Add("infamy", character.baseInfamy);
        captainTraits.Add("luck", character.baseLuck);
        level = 1;
    }

    public void levelUp()
    {
        level++;
        int luck = captainTraits["luck"];
        int traitsToLevel = 1 + Mathf.RoundToInt(2f*Random.Range(0f,luck/20f));
        for (int i = 0; i < traitsToLevel; i++)
        {
            int j = Random.Range(0, captainTraits.Count); // this includes luck
            string trait = captainTraits.Keys.ToList()[j];
            captainTraits[trait]++;
            Debug.Log(string.Format("Leveled {0}", trait));
        }
    }

    public void levelUp(int traitsToLevel)
    {
        level++;
        for (int i = 0; i < traitsToLevel; i++)
        {
            int j = Random.Range(0, 3); // this includes luck
            string trait = captainTraits.Keys.ToList()[j];
            captainTraits[trait]++;
            Debug.Log(string.Format("Leveled {0}", trait));
        }
    }

    public void renameCaptain(string _name)
    {
        name = _name;
    }
}
