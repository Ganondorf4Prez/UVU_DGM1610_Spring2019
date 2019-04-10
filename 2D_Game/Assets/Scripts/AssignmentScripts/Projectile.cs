using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;

    public float timeOut;
    public GameObject player;

    public GameObject enemyDeath;

    public GameObject projectileParticle; //if it hits something else other than enemy

    public int pointsForKill;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player)");

        enemyDeath = Resources.Load("Prefabs/PS") as GameObject;

        projectileParticle = Resources.Load("Prefabs/PS") as GameObject;

        if (player.transform.localScale.x < 0)
            speed = -speed;

        //Destroy projectile after x seconds
        Destroy(gameObject, timeOut);
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroys enemy on contact with projectile / add points
        if(other.tag == "Enemy")
        {
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints(pointsForKill);
        }
        Destroy(gameObject); //projectile is destroyed after hitting an enemy

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(projectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
        
    



}
