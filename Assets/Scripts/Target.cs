using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public float maxHealth = 50f;

    //private GameGUI gUI;
    public Image healthBar;
    public GameObject gUI;

    private void Start()
    {
        health = maxHealth;
    }
    private void Update()
    {
        healthBar.fillAmount = health / maxHealth;
    }

    private void Awake()
    {
        //gUI = GameObject.FindGameObjectWithTag("GUI").GetComponent<GameGUI>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
