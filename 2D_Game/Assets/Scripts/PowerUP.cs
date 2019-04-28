using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour {

    public float multiplier = 4.0f;
    public float duration;
    public GameObject pickUpEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            StartCoroutine(PickUp(other));
        }
    }

    IEnumerator PickUp(Collider2D player)
    {
        Instantiate(pickUpEffect, transform.position, transform.rotation);


        UserCtrl speedup = player.GetComponent<UserCtrl>();


        
        speedup.userSpeed *= multiplier;

        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        speedup.userSpeed /= multiplier;
        



        Destroy(gameObject);
    }

}
