using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        //Destroy this object
        Destroy(this.gameObject);

        //Alive count -1
        GameObject.Find("Text_Alive").GetComponent<AlivePlayer>().countAlive--;
    }
}
