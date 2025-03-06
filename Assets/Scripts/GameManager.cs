using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public int Ring = 0;
    public TextMeshProUGUI ringText;

    public static GameManager gameManager { get; private set;}
    public PlayerBehaviour player;

    public UnitHealth _playerHealth = new UnitHealth(100, 100);

    void Awake()
    {
       if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }

    
}
