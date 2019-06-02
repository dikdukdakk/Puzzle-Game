using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision ball)
    {
        if (ball.gameObject.name != "getPoint")
            return; //Active GameOverUI

        GameManager.current.GameWin();
        GameManager.current.isCompleted = true;
    }
}
