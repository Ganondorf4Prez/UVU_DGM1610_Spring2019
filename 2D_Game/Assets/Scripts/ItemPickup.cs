using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public int coinValue;
    

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Player")
        {
            print("You've collected the item, m8");
            
            

            ScoreManager.AddPoints(coinValue);

            Destroy(gameObject); 
        }


    }
    //Add a game object later on

    //Add coins to the game for bonus points, similar to the ''eight red coins'' of mario
    //Front, Side, 3/4ths, Back of coin needed; The coin can be lime green with a beetle
}
