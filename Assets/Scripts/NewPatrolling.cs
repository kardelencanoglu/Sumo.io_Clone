using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewPatrolling : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> points;
    [SerializeField]
    private NavMeshAgent agent;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private NewPatrolling[] fellowAI;
    [SerializeField]
    private GameObject [] chaseSpots;

    private int currPoint;
    public bool patrolling;
    public PlayerController playercontroller;
    private Vector3 temphold;

    private void Start()
    {
        patrolling = true;
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        currPoint = 0;
        agent.destination = points[currPoint].transform.position;
    }

    private void Update()
    {
        if(patrolling)
        {
        if(Vector3.Distance(this.transform.position, player.transform.position)<=10f)
        {
            AttackPlayer();
            temphold = player.transform.position;
            AddWaypoints();
            agent.speed = 10f;
            agent.destination = player.transform.position;
        }
        if(Vector3.Distance(this.transform.position,player.transform.position)<=10f)
        {
            agent.speed = 7.5f;
            agent.destination = points[currPoint].transform.position;
        }
        if(Vector3.Distance(this.transform.position,player.transform.position)<=1f)
        {
            //code for attack
            //playercontroller.HP -= 20;
            //play animation for an attack
            //SceneManager.Load
        }
        if(Vector3.Distance(this.transform.position,points[currPoint].transform.position)<=2f)
        {
            Iterate();
        }
        }
        if(!patrolling)
        {
            if(CheckDistance())
            {
                AttackPlayer();
            }
            else
            {
                temphold = this.GetComponent<NavMeshAgent>().destination;
                AddWaypoints();
                patrolling = true;
            }
        }
    }

    void Iterate()
    {
        if(currPoint<points.Count -1) //my list 0123
        {
            currPoint++;
        }
        else
        {
            currPoint = 0;
        }
        agent.destination = points[currPoint].transform.position;
    }
    void AttackPlayer()
    {
        int k = 0;
        foreach(NewPatrolling n in fellowAI)
        {
            n.patrolling = false;
           // n.agent.destination = player.transform.position;
           n.agent.destination = chaseSpots[k].transform.position;
           k++;
           if(k>=chaseSpots.Length)
           {
               k = 0;
           }
        }
    }
    public bool CheckDistance()
    {
        for (int i=0; i <fellowAI.Length;i++)
        {
            if(Vector3.Distance(fellowAI[i].transform.position,player.transform.position)<=10f)
            {
                return true;
            }
        }
        playercontroller.EmptySpots();
        return false;
    }

    void AddWaypoints()
    {
        points.Add(new GameObject());
        points[points.Count-1].transform.position = temphold;
    }
}


