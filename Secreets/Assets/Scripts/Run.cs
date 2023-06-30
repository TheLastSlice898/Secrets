using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{

    public float RunSpeed;
    public bool HitWall;
    public int RunDistance;
    public float PlayerInput;
    public float Sensitivity;
    public GameObject Camera; 
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void TrunLeft()
    {
         transform.rotation = transform.rotation * Quaternion.Euler(0f,-90f,0f);
    }
    public void TurnRight()
    {
    transform.rotation = transform.rotation * Quaternion.Euler(0f,90f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        float VerticalInput = Input.GetAxis("Vertical");
        float RunForward = (VerticalInput * 0.05f) * Sensitivity;

        if (HitWall == true)
        {
            Debug.Log("ow that hurts");
        }    

    if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           TrunLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           TurnRight();
        }
        transform.position = transform.position + (transform.forward * RunForward);
    }


    void OnCollisionEnter(Collision Collider)
    {
    HitWall = true;
    }
    void OnCollisionExit(Collision Collider){
    HitWall = false;
    }
}
