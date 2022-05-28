using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject start;
     public float timeRemaining = 10;
    public bool timerIsRunning = false;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Instantiate(myPrefab,start.transform.position, Quaternion.identity);
                Debug.Log("Time has run out!");
                timeRemaining = 10;
                timerIsRunning = true;
            }
        }
    }
}
