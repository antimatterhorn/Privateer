using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CaptainController : MonoBehaviour
{
    public Character character;
    public SpriteRenderer spriteRenderer;

    private Captain captain;

    // Start is called before the first frame update
    void Start()
    {
        //string[] folders = 

        //public static string[] chars = AssetDatabase.FindAssets("", );
        Object[] allchars = Resources.LoadAll("Characters");
        int j = Random.Range(0, allchars.Length - 1);

        captain = new Captain((Character)allchars[j]);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = captain.character.portrait;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
