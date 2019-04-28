using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] TankSprites;

    public Image TankUI; //Empty Tank

    private UserCtrl player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<UserCtrl>();

    }
    void Update()
    {
        TankUI.sprite = TankSprites[player.userHealth];
        
    }

}
