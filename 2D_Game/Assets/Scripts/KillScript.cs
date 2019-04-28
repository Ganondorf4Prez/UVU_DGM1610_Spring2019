using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour {
    //Removed script "Kill Player" off of the enemy

    public LevelManager manageCall;

    void Start()
    {
        manageCall = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UserCtrl HP = other.GetComponent<UserCtrl>();
            if(HP.userHealth == 1)
            {
                manageCall.RespawnPlayer();
                HP.userHealth += 9;
            }
            else if(HP.userHealth > 1){
                HP.userHealth -= 1;
                other.GetComponent<Rigidbody2D>().velocity *= -2;
            }
        }
    }

}
