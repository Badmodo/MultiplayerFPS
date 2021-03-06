using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public float expOnDeath;
    private PlayerDetails player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDetails>();
    }

    //being i made this virtual in the shared Character file we can add to it
    public override void Die()
    {
        player.AddExperience(expOnDeath);
        base.Die();
    }
}
