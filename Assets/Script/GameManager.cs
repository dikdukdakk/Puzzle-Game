using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager current;
    public GameObject GameOverUI;

    bool isAlive;

    void Start()
    {
        current.isAlive = true;
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        current.isAlive = false;
        current.GameOverUI.SetActive(true);
        Time.timeScale = 0f;

    }

}
