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
        PlayerShoot beam = player.GetComponent<PlayerShoot>();

        beam.projectile = Resources.Load("Prefabs/SuperLaser") as GameObject;

        
        speedup.userSpeed *= multiplier;

        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(duration);

        speedup.userSpeed /= multiplier;
        beam.projectile = Resources.Load("Prefabs/Laser") as GameObject;



        Destroy(gameObject);
    }

}
