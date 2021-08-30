using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int PointAmount;
    public Transform player;

    private GameManager gm;

    void Start()
    {
       gm = GameObject.FindObjectOfType<GameManager>();
    }


    /*void Update() 
    /{
        if(transform.position.x + 10f >= player.position.x)//
        {
            Destroy(gameObject);
          
        }
    } */
}

