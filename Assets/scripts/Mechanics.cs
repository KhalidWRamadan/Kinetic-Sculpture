
using UnityEngine;

public class Mechanics : MonoBehaviour
{
    public float rotationSpeed = 20f; 

    private float initY;
    private float initZ;

    void Start()
    {

        initY = transform.rotation.y;
        initZ = transform.rotation.z;
    }
    void Update()
    {

        transform.rotation = Quaternion.Euler(rotationSpeed * Time.time, initY, initZ);

    }



}
