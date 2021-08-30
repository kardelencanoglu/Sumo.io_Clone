using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform player;
    float speed = 10f;
    float force = 2f;

    bool hitting;

    Vector3 initialPos; 

    private GameManager gm;

    private void Start()
    {
        initialPos = transform.position; 
         gm = GameObject.FindObjectOfType<GameManager>();
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.W))
        {
            hitting = true;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            hitting = false;
        }

        if(hitting)
        {
            player.Translate(new Vector3(h, 0, 0) * Time.deltaTime);
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
        GetComponent<Rigidbody>().velocity = force* new Vector3(1, 1, 0);
            transform.position = initialPos;
        Vector3 dir = player.position - transform.position;
        other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0, 1, 1 );
        }

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name; //recognizing where it hit
        Debug.Log("Materyal Adı: " + materialName);

        //if(materialName == "Arena (Instance)") { // survive
        
         if (materialName == "DeathZone (Instance)")
          {
            Debug.Log("Game Over!");
        
            //Destroy(gameObject);
        }


    }
}


