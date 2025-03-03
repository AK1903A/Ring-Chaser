using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour

{  [SerializeField] Healthbar _healthbar;
   
    void Start()
    {
        
    }

   
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerTakeDmg(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
      if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerHeal(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
    }
    public void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.Health);
        if (GameManager.gameManager._playerHealth.Health <= 0)
        {
            SceneManager.LoadScene(2);
        }

    }
     public void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }

}
