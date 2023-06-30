using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public bool timerOn;
    public float timeLeft; 
    // Start is called before the first frame update
    void Start()
    {
        timerOn = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn)
        {
            if(timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTime(timeLeft);
            }
            else
            {
                Debug.Log("you lose");
                timeLeft = 0;
                timerOn = false;
            }
        }
    }
  private void updateTime(float currentTime)
    {
        float minute = Mathf.FloorToInt(currentTime / 60);
        float second = Mathf.FloorToInt(currentTime % 60);
    }


}
