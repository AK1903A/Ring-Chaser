using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCrash : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource crashAudio;

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            crashAudio.Play();
        }
    }
}
