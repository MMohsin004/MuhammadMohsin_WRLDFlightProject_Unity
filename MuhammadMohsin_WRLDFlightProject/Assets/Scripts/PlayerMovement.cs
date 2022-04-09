using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float upForceMultiplier;
    [SerializeField]
    private float forwardForceMultiplier;
    [SerializeField]
    private float turnForceMultiplier;
    [SerializeField]
    private float turnFactor;
    private float x, y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        
        if (GameManager.instance.engineRunning)
        {
            x = Input.GetAxisRaw("Horizontal");
            y = Input.GetAxisRaw("Vertical");
            
            //Ascend control
            if (Input.GetKeyDown(KeyCode.Z))
            {
                rb.AddForce(Time.fixedDeltaTime * upForceMultiplier * transform.up, ForceMode.VelocityChange);
            }
            //Descend control
            if (Input.GetKeyDown(KeyCode.X))
            {
                rb.AddForce(Time.fixedDeltaTime * upForceMultiplier * -transform.up, ForceMode.VelocityChange);
            }

            rb.AddForce(Time.fixedDeltaTime * turnForceMultiplier * x * transform.right, ForceMode.VelocityChange);
            rb.AddTorque(Time.fixedDeltaTime * turnFactor * x * transform.up,ForceMode.VelocityChange);
            rb.AddForce(forwardForceMultiplier * Time.fixedDeltaTime * y * transform.forward, ForceMode.VelocityChange);
            
        }
    }
}
