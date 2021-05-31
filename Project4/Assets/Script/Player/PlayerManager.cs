using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{

    public static bool gameOver;
    public GameObject gameoverPanel;
    public static int noOfCoins;
    public static int noOfShield;
    public TextMeshProUGUI coinText;
    public static bool isGameStarted;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        noOfCoins = 0;
        noOfShield = 0;
        isGameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        {
           
            coinText.text = "Coin:" + noOfCoins;
        }

    }
}
