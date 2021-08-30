using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject[] Points;

    public float waitForNextSpawnPoint = 0.1f;
    public float StartWait = 0.1f;

    public float xMin;
    public float xMax;

    public float yMin;
    public float yMax;
    
    public float zMin;
    public float zMax;


    public void Update ()
    {
        StartWait -= Time.deltaTime;
        if(StartWait <= 0)
        {
            Spawn ();
            StartWait = waitForNextSpawnPoint;
        }
    }

    public void Spawn ()
    {
        Vector3 pos = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), Random.Range(zMin, zMax));

        GameObject PointPreFab = Points [Random.Range (0, Points.Length)];

        Instantiate (PointPreFab, pos, transform.rotation);
    }
}
