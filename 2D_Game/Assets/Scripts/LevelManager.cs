using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckPoint;
    public Rigidbody2D pcRigid;

    private GameObject player;

    //Particles
    public GameObject deathParticle;
    public GameObject respawnParticle;

    //Respawn Delay
    public float respawnDelay;

    //Point Penalty on Death
    public int pointPenaltyOnDeath;

    //Store Gravity Value
    private float gravityStore;

    //Player Health Value
    

	void Start () {
        
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
	}

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }
	
    //IEnumerator is the CoRoutine
    public IEnumerator RespawnPlayerCo()
    {
        //Generate Death Particle
        Instantiate(deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);

        //Hide PC
        player.SetActive(false);
        pcRigid.GetComponent<Renderer>().enabled = false;

        //GravityReset
        gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        //Point Penalty
        ScoreManager.AddPoints(-pointPenaltyOnDeath);

        //Debug Message
        Debug.Log("PC Respawn");

        //Respawn Delay
        yield return new WaitForSeconds(respawnDelay);

        //Gravity Restore
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;


        //Match pcRigids transform position
        pcRigid.transform.position = currentCheckPoint.transform.position;

        //Show pcRigid
        player.SetActive(true);
        pcRigid.GetComponent<Renderer>().enabled = true;

        //Spawn pcRigid
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);

    }

	// Update is called once per frame
	void Update () {
		
	}
}
