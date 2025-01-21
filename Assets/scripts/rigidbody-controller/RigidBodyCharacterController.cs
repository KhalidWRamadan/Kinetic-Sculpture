using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyCharacterController : MonoBehaviour
{
    Rigidbody rb;
    Vector3 input;
    public float speed = 10.0f;
    bool isJumping = false;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        //bitwise operator | used to combine two constraints 
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        rb.mass = 10;
    }

    //physics calculations should be done in FixedUpdate
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + input * Time.fixedDeltaTime);
        // rb.velocity = input;
        if (isJumping)
        {
            rb.drag = 0.3f;
            rb.AddForce(Vector3.up * 50f, ForceMode.Impulse);
            isJumping = false;
        }
        rb.drag = 0f;
    }
    void Update()
    {
        // we use GetAxisRaw to get the input without smoothing
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        input = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // we use normalized to make sure that the speed is the same in all directions
        //so when we push two buttons at the same time we don't move faster
        input = input.normalized * speed;

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping) isJumping = true;

    }
}
