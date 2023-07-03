using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickObject : MonoBehaviour
{
    public GameObject Mushroom; 

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            print("Correct");
        }
        if (Input.GetMouseButtonUp(0))
        {
           Destroy(Mushroom);
        }
    }
}
