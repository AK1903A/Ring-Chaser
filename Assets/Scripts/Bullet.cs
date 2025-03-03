using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    public float trackingSpeed = 0.1f;
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 LookDirection = GameManager.gameManager.player.transform.position - transform.position;
        LookDirection.Normalize();
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(LookDirection),trackingSpeed*Time.deltaTime);
      
        transform.position += transform.forward*speed*Time.deltaTime; 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameManager.gameManager.player.GetComponent<PlayerBehaviour>().PlayerTakeDmg(10);
            Destroy(gameObject);
        }

    }
    public IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}

