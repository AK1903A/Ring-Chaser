using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryBallons : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameManager.gameManager.player.GetComponent<PlayerBehaviour>().PlayerTakeDmg(3);
            Destroy(gameObject);
        }

    }
}
