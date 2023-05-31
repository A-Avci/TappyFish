using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomleft;
    public static bool gameover;
    public GameObject gameOverPanel;

    private void Awake()
    {
        bottomleft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
    }

    void Start()
    {
        gameover = false;
    }

    public void GameOver()
    {
        gameover = true;
        gameOverPanel.SetActive(true);
    }

    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    
    void Update()
    {
        
    }
}
