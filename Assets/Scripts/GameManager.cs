using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomleft;
    public static bool gameover;
    public GameObject gameOverPanel;
    public static bool gameStarted;
    public GameObject getReadyImg;
    public GameObject score;
    public static int gameScore;

    private void Awake()
    {
        bottomleft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        gameover = false;
    }

    void Start()
    {
        gameStarted = false;
    }

    public void GameOver()
    {
        gameover = true;
        gameScore = score.GetComponent<Score>().GetScore();
        gameOverPanel.SetActive(true);
        score.SetActive(false);
    }

    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameHasStarted()
    {
        gameStarted = true;
        getReadyImg.SetActive(false);
    }
    
    
    void Update()
    {
        
    }
}
