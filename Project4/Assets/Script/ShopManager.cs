using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int currntCharactrIndex = 0;
    public GameObject[] charactersModel;
    // Start is called before the first frame update
    void Start()
    {
        currntCharactrIndex = PlayerPrefs.GetInt("SELECT AVATER", 0);
        foreach(GameObject character in charactersModel)
            
            character.SetActive(false);
            charactersModel[currntCharactrIndex].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeNext()
    {
        charactersModel[currntCharactrIndex].SetActive(false);
        currntCharactrIndex++;
        if (currntCharactrIndex == charactersModel.Length)
            currntCharactrIndex = 0;
        charactersModel[currntCharactrIndex].SetActive(true);
           PlayerPrefs.SetInt("SELECT AVATER", currntCharactrIndex);
    }
    public void changePervrous()
    {
        charactersModel[currntCharactrIndex].SetActive(false);
        currntCharactrIndex--;
        if (currntCharactrIndex ==-1 )
            currntCharactrIndex = charactersModel.Length - 1;
        charactersModel[currntCharactrIndex].SetActive(true);
        PlayerPrefs.SetInt("SELECT AVATER", currntCharactrIndex);
    }
}
