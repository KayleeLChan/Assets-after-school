using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{

    public AudioSource music;

    //Play music when player enters instrument zone
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            music.Play();
            Debug.Log("Playing Music");
        }
    }

    //Pause music when player leaves zone
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            music.Pause();
            Debug.Log("Pausing Music");
        }
    }
}
