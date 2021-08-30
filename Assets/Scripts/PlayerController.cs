using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool[] Spots;
    
    private void Start()
    {
        EmptySpots();
    }
    public void EmptySpots()
 {
     for(int i=0; i <Spots.Length; i++)
     {
         Spots[i] = false;
     }
 }
    private void Update()
    {
        
    }
}
