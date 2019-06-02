using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.current.isPause)
            return;

        //Destroy this object
        Destroy(this.gameObject);

        //Alive count -1
        GameManager.current.countAlive--;
    }
}
