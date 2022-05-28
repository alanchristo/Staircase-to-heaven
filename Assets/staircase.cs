using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staircase : MonoBehaviour
{
    public GameObject target;
    [SerializeField]
    private float timeRemaining = 30;
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
       target = GameObject.Find("End");
       timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=  Vector3.MoveTowards(transform.position,target.transform.position,Time.deltaTime * 0.5f);
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
               // DestroyGameObject();
                Debug.Log("obj des");
                timeRemaining = 10;
                timerIsRunning = true;
            }
        }
    }
     void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
