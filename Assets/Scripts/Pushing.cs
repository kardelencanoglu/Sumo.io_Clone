using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushing : MonoBehaviour
{
    
    public Transform AI;
    float speed = 3f;
    float force = 2f;

    bool hitting;

    Vector3 initialPos; 

    private void Start()
    {
        
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if(hitting)
        {
            AI.Translate(new Vector3(h, 0, 0) * Time.deltaTime);
        }

        if( (h !=0 || v !=0) && !hitting)
        {
            transform.Translate( new Vector3(h, 0, v) * speed * Time.deltaTime);
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("AI"))
        {
        GetComponent<Rigidbody>().velocity = force* new Vector3(0, 5, 0);
            transform.position = initialPos;
        Vector3 dir = AI.position - transform.position;
        other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0, 5, 0 );
        }
    }
}
