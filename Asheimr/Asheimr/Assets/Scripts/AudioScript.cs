using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
     
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        audioSource.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        //checking if object is the player then playing the audio in the target zone
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //if player leaves trigger zone
        if (other.CompareTag("Player"))
        {
            audioSource.Stop();
        }
    }
}
