using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager current;

    [Header("GAME UI")]
    public GameObject gameWinUI;
    public GameObject gameOverUI;
    public GameObject gamePauseUI;

    [Header("ALIVE")]
    public GameObject textAlive;

    [Header("TIME")]
    public GameObject textTime;

    private void Start()
    {
        current = this;
    }

    public void OnGameWinUI()
    {
        gameWinUI.SetActive(true);
    }

    public void OnGameOverUI()
    {
        StartCoroutine("DelayActiveGameOver");
    }

    IEnumerator DelayActiveGameOver()
    {
        yield return new WaitForSeconds(1.5f);
        gameOverUI.SetActive(true);
    }

    public void OnGamePauseUI()
    {
        gamePauseUI.SetActive(true);
    }

    public void OffGameWinUI()
    {
        gameWinUI.SetActive(false);
    }

    public void OffGameOverUI()
    {
        gameOverUI.SetActive(false);
    }

    public void OffGamePauseUI()
    {
        gamePauseUI.SetActive(false);
        GameManager.current.isPause = false;
    }

    public void BTreplay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BThome()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void UpdateTextAlive()
    {
        textAlive.GetComponent<Text>().text = "Destory Blocks " + GameManager.current.countAlive;
    }

    public void UpdateTextTime(float time)
    {
        int minutes = (int)(time / 60);
        float seconds = time % 60f;
        textTime.GetComponent<Text>().text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

}
