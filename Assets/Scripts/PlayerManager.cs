using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public int ScalePoints;
    private int Score;
    //public Text ScoreText;

    void Start()
    {
        //Score = 0;
        //SetScoreText();
    }
    
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Point")
        {
            this.transform.localScale += new Vector3(ScalePoints , ScalePoints, 0);
            //ScalePoints += other.gameObject.GetComponent<Point>().PointAmount;
            Destroy (other.gameObject);
            //Score = Score + 1;
            //SetScoreText();
        }
    }

    /*void SetScoreText()
    {
        ScoreText.text = "Score:" + Score.ToString();

    }*/
}