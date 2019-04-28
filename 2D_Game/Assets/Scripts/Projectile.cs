using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    

    public float timeOut;
    public GameObject player;

    public GameObject enemyDeath;

    public GameObject breakDeath;

    public GameObject projectileParticle; //if it hits something else other than enemy

    public int pointsForKill;

    
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        UserCtrl direction = player.GetComponent<UserCtrl>();

        enemyDeath = Resources.Load("Prefabs/PS") as GameObject;

        breakDeath = Resources.Load("Prefabs/Break") as GameObject;

        projectileParticle = Resources.Load("Prefabs/PS") as GameObject;

        //Destroy projectile after x seconds
        Destroy(gameObject, timeOut);
		
	}
    void Update()
    {
        UserCtrl aim = player.GetComponent<UserCtrl>();
        if (aim.faceRight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if (!aim.faceRight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
        }
        

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

        //projectile is destroyed after hitting an enemy

        else if(other.tag == "Breakable")
        {
            Instantiate(breakDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(projectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
        
    



}
