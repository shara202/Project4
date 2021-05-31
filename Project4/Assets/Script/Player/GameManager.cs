using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;

     private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        isGameActive=false;
        score =0;

        
    }

//Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            Time.timeScale = 0;  
        }
        else
        {
            UpdateScore(1);
        }


    }
   void UpdateScore(int ScoreToAdd)
    {
        score += ScoreToAdd;
        scoreText.text = "Score:" + score;
    }
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
