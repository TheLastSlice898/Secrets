using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class CatchTheBook : MonoBehaviour
{
    public TextMeshProUGUI healthBox;
    int bookHealth; 

    public float secondCounter; 
    public float FlyTime; 
    public bool BookIsFlying;

    public bool BookOnLeft;
    public bool BookOnRight;

    // Start is called before the first frame update
    void Start()
    {
        bookHealth = 3; 
        healthBox.text = "Book HP: " + bookHealth; 
        
        BookOnLeft = true; 
        BookOnRight = false; 
        transform.position = new Vector3(-4.67f, 0.87f, -7.72f); 

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
            BookIsFlying = true;
            Debug.Log("Fly you fool"); 
        }

        if(Input.GetKeyDown("space") && BookIsFlying == true) {
            bookHealth -= 1; 
            healthBox.text = "Book HP: " + bookHealth; 
             
            secondCounter = 0f; 
            FlyTime = 100f; 

            if(BookOnLeft == true) { 
                Debug.Log("Amogus");
                BookOnRight = true; 
                BookOnLeft = false;
                transform.position = new Vector3(-4.67f, 0.87f, 7.72f);
                } 
                else {
                    Debug.Log("Sussy");
                    BookOnRight = false; 
                    BookOnLeft = true; 
                    transform.position = new Vector3(-4.67f, 0.87f, -7.72f);  
                    }

            RandomiseFlyTime(); 
            BookIsFlying = false;
        }

        if(BookIsFlying == true && BookOnLeft == true) {
            transform.position += new Vector3(0,0,20) * Time.deltaTime;
        }

        if(BookIsFlying == true && BookOnRight == true) {
            transform.position += new Vector3(0,0,-20) * Time.deltaTime;
        }
    }

    public void RandomiseFlyTime()
    {
        FlyTime = Random.Range(1,10); 
    }
}
