using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public int currntCharactrIndex = 0;
    public GameObject[] chara;
    // Start is called before the first frame update
    void Start()
    {
        currntCharactrIndex = PlayerPrefs.GetInt("SELECT AVATER", 0);
        foreach (GameObject character in chara)
        
            character.SetActive(false);
            chara[currntCharactrIndex].SetActive(true);
        
    }
}

