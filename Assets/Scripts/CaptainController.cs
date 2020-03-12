using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainController : MonoBehaviour
{
    public Character character;
    public SpriteRenderer spriteRenderer;

    private Captain captain;

    // Start is called before the first frame update
    void Start()
    {
        Object[] allchars = Resources.LoadAll("Characters");
        int j = Random.Range(0, allchars.Length - 1);
        character = (Character)allchars[j];

        captain = new Captain(character);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = captain.character.portrait;
        LevelUp();
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
