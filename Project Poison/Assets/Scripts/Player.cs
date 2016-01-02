using UnityEngine;
using System.Collections;
using System;


public class Player : MonoBehaviour {

    float attack;
    float defense;
    int health;
    int energy;
    float critChance;
    float critMultiplier;
    System.Random rand;


	// Use this for initialization
	void Start () {
        rand = new System.Random();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
