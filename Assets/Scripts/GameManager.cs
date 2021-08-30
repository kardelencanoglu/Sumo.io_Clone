using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Text point;
    public Text pointText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GameScore () 
    {
        point = pointText;
        pointText.text = point.ToString();
    }



    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}