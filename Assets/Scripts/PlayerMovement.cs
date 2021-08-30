using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1, 0, 0);
        }
        
        
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, 0, 1);
        }
        
        /*
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 30);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 30);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 30);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 30);
        }
*/

    }
}