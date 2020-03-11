using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public new string name;
    public Sprite portrait;

    public int baseAccuracy;
    public int baseInspiration;
    public int baseInitiative;
    public int baseLuck;
}
