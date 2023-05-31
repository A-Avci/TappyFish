using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomleft;
    public static bool gameover;

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
    }
    
    
    void Update()
    {
        
    }
}
