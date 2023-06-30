using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrack : MonoBehaviour
{
    public Transform CamTrans;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = CamTrans.transform.position;
        gameObject.transform.rotation = CamTrans.transform.rotation;
    }
}
