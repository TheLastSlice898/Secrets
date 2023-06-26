using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{

    public List<Transform> dropPoints;
    public List<Drag> draggable;
    public float snap = 0.5f;


    public void OnDragEnded(Drag Drag)
    {
       float closestDistance = -1;
       Transform closestSnapPoint = null;
       foreach(Transform snap in snapPoint)
        {

        }
    }
}
