using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInfo : MonoBehaviour
{
    //Message for placard to relay
    public string message;

    //When player approaches placard, inform them about display
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("" + message);
        }
    }
}
