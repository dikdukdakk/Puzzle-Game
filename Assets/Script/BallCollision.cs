using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name != "Pass")
            return; //Active GameOverUI

        Debug.Log("Good Job!!");
    }
}
