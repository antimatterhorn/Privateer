using UnityEngine;
using UnityEngine.UI;


public class Captain
{
    public Character character;
    public Sprite portrait;
    public string name;
    public string title;

    public int level;

    public int accuracy;
    public int inspiration;
    public int initiative;
    public int luck;

    public Captain (Character baseCharacter)
    {
        character = baseCharacter;
        name = character.name;
        portrait = character.portrait;
        accuracy = character.baseAccuracy;
        inspiration = character.baseInspiration;
        initiative = character.baseInitiative;
        luck = character.baseLuck;
        level = 1;
    }

    public void levelUp()
    {
        level++;
        int traits = 2;


    }

    public void levelUp(int traits)
    {
        level++;

    }
}
