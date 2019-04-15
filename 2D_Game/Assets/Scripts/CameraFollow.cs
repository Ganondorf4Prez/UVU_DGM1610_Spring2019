using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public UserCtrl player;

    public bool isFollowing;

    //Camera position offset
    public float xOffset;
    public float yOffset;


	void Start () {
        player = FindObjectOfType<UserCtrl>();

        isFollowing = true;
		
	}
	
	void Update () {
        if (isFollowing)
        {
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, player.transform.position.z);
        }
		
	}
}
