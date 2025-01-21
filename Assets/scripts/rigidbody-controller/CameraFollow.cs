using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 offset = new Vector3(1f, 0f, -3.5f);
    void Start()
    {
        // if (target != null)
        //     transform.position = target.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
