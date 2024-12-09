using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breathingEffect : MonoBehaviour
{
    float initX;
    float initY;
    float initZ;
    // Start is called before the first frame update
    void Start()
    {
        initX = transform.localScale.x;
        initY = transform.localScale.y;
        initZ = transform.localScale.z;
    }

    // Update is called once per frame
    void Update()
    {
        float newX = Mathf.Cos(Time.time * 2) + 2.5f;
        transform.localScale = new Vector3(initX, initY, initZ) * newX / 4;

    }
}
