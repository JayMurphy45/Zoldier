using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //Variables
    public float health;
    public float pointsToGive;
    private GameObject Player;
    private Rigidbody enemy;
    public Transform target;
    public float speed;
    public float withinRange;


    public GameObject player;


    //Methods
    public void Start()
    {
        enemy = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    public void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);

        if(dist <= withinRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position ,speed);
        }

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);

        player.GetComponent<PlayerController>().points += pointsToGive;
    }

}
