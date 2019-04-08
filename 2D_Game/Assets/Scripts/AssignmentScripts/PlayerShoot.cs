﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public Transform firePoint;
    public GameObject projectile; //Add the laser(s) here!

	
	void Start () {
        //Load projectile from resources/prefab folder
        projectile = Resources.Load("Prefabs/Projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
            Instantiate(projectile, firePoint.position, firePoint.rotation);
	}
}
