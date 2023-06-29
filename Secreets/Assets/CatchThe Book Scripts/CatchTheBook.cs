using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchTheBook : MonoBehaviour
{
    float secondCounter; 
    float FlyTime; 
    bool BookIsFlying;

    // Start is called before the first frame update
    void Start()
    {
        secondCounter = 0.0f;
        BookIsFlying = false; 

        RandomiseFlyTime(); 
    }

    // Update is called once per frame
    void Update()
    {
        secondCounter += Time.deltaTime; 
        //Debug.Log(secondCounter);
        //Debug.Log(FlyTime); 

        if(secondCounter >= FlyTime && BookIsFlying == false) {
            BookFly();
            Debug.Log("Fly you fool"); 
        }
    }

    public void BookFly()
    {
        BookIsFlying = true; 
        Debug.Log(BookIsFlying); 
    }

    public void RandomiseFlyTime()
    {
        FlyTime = Random.Range(1,10); 
    }
}
