using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager current;

    [Header("GAME STATUS")]
    public bool isCompleted;
    public bool isPause;
    public float totalGameTIme;

    [Header("STAR of count")]
    public GameObject[] STAR;

    [Header("Count of Alive")]
    public int countAlive;



    void Start()
    {
        current = this;
        current.isCompleted = false;
        current.isPause = false;
    }

    void Update()
    {
        GameStatus();

        UpdateAlivePlayer();
        if (countAlive == 0)
            GameOver();

        totalGameTIme += Time.deltaTime;
        UpdateTime(totalGameTIme);
    }

    void GameStatus()
    {
        if (isCompleted == true)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;

        if (isPause == true)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void GameWin()
    {
        UIManager.current.OnGameWinUI();
        if (countAlive == 2 && totalGameTIme < 7)
            STAR[2].SetActive(true);
        else if (countAlive == 2 || countAlive == 1 && totalGameTIme < 10)
            STAR[1].SetActive(true);
        else
            STAR[0].SetActive(true);
    }

    public void GameOver()
    {
        UIManager.current.OnGameOverUI();
    }

    public void GamePause()
    {
        isPause = true;
        UIManager.current.OnGamePauseUI();
    }

    public void UpdateAlivePlayer()
    {
        if (isCompleted)
            return;

        UIManager.current.UpdateTextAlive();
    }

    public void UpdateTime(float time)
    {
        if (isCompleted)
            return;

        UIManager.current.UpdateTextTime(time);
    }

  
}
