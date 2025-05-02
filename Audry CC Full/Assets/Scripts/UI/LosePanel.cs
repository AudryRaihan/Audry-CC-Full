using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{

    [Header("Level Information")]
    //public string levelToLoad;
    private int level;
    private GameData gameData;
    private int starsActive;
    private int highScore;
    private Board board;

    [Header("UI stuff")]
    public Image[] stars;
    public Text ScoreText;
    //public Text starText;
    public Text levelText;



    // Use this for initialization
    void OnEnable()
    {
        board = FindObjectOfType<Board>();
        level = board.level + 1;
        gameData = FindObjectOfType<GameData>();
        LoadData();
        ActivateStars();
        SetText();
    }

    void LoadData()
    {
        if (gameData != null)
        {
            starsActive = gameData.saveData.stars[level - 1];
            highScore = gameData.saveData.highScores[level - 1];
        }
        else
        {
            Debug.Log("Game data null");
        }
    }

    void SetText()
    {
        ScoreText.text = "" + highScore;
        //starText.text = "" + starsActive + "/3"; 
        
        levelText.text = "" + level;
    }

    void ActivateStars()
    {
        //COME BACK TO THIS WHEN THE BINARY FILE IS DONE!!!
        for (int i = 0; i < starsActive; i++)
        {
            stars[i].enabled = true;
        }
        Debug.Log("stars : " + starsActive);
    }

    public void Retry()
    {
        SceneManager.LoadScene(level);
    }
}
