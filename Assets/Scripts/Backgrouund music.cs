using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgrouundmusic : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.M)) 
        
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();

            }
            else
            {
                audioSource.Play();
            }
        }
        
    }


}
