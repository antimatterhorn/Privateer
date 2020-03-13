using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainController : MonoBehaviour
{
    public Character character;
    public SpriteRenderer spriteRenderer;
    public Nationality nationality;


    private Captain captain;
    public int luck;

    // Start is called before the first frame update
    void Start()
    {
        character = ScriptableObject.CreateInstance<Character>();
        character.GetRandomFrom(nationality);
        captain = new Captain(character);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = captain.character.portrait;
        LevelUp();
        luck = captain.captainTraits["luck"];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LevelUp()
    {
        captain.levelUp();
    }
}
