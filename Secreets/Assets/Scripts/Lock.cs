using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lock : MonoBehaviour
{
    // Start is called before the first frame update

    public bool left;
    public bool right;
    public bool isPlaced; 

    public void OnCollisionEnter(Collision collision)
    {
      if(left == true)
        {
         
        }
      else
      {
        left = false;
        right = true;
        
      }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
