﻿using UnityEngine;
using System.Collections;

public class BronusBrothers : MonoBehaviour {


    int attack;
    int defense;
    int dodge;
    int hit;
    int health;
    int energy;
    int critChance;
    float critMultiplier;
    bool alive;
    System.Random rand;


    // Use this for initialization
    void Start()
    {
        rand = new System.Random();
        health = 80;
        hit = 90;
        dodge = 10;
        critChance = 10;
        attack = 4;
        critMultiplier = 1.5f;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    bool Hit(int dodge)
    {
        int random = rand.Next(0, hit);
        if (random > dodge)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool Dodge(int hit)
    {
        int random = rand.Next(0, hit);
        if (random > dodge)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void DamageRecieved(int enemyDamage)
    {
        health = enemyDamage - defense;
        if(health <=0)
        {
            alive = false;
            SendMessage("Win");
        }
    }

    int Dealdamage()
    {
        int damage;
        bool crit = Crit();
        if (crit)
        {
            damage = (int)(attack * critMultiplier);
        }
        else
        {
            damage = attack;
        }
        return damage;
    }

    bool Crit()
    {
        int chance = rand.Next(0, 100);
        if (chance <= critChance)
        {
            return true;
        }
        return false;
    }
}
