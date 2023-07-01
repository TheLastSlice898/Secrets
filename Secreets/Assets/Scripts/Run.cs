using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField] private Waypoint wayPoints;

    public float MoveSpeed;


    private Transform currentWaypoint;

    public float RunSpeed;
    public bool HitWall;
    public float DistanceThreshhold;
    public float PlayerInput;
    public float Sensitivity;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        currentWaypoint = wayPoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        currentWaypoint = wayPoints.GetNextWaypoint(currentWaypoint);
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


        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, MoveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, currentWaypoint.position) < DistanceThreshhold)
        {
            currentWaypoint = wayPoints.GetNextWaypoint(currentWaypoint);
            transform.LookAt(currentWaypoint);
        }



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
    }


    void OnCollisionEnter(Collision Collider)
    {
    HitWall = true;
    }
    void OnCollisionExit(Collision Collider){
    HitWall = false;
    }
}
