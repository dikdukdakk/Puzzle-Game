﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AlivePlayer : MonoBehaviour
{
    public int countAlive;   //Count ALive
    private void Update()
    {
        GetComponent<Text>().text = "Destory Blocks " + countAlive;

        if (countAlive == 0) //When CountAlive = 0. Active GameOverUI
            GameManager.current.GameOver();
    }
}
