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
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        if (GameManager.instance.engineRunning)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Time.fixedDeltaTime * upForceMultiplier * transform.up, ForceMode.VelocityChange);
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.velocity = Vector3.Lerp(rb.velocity,Vector3.zero,3f);
            }
            rb.AddForce(Time.fixedDeltaTime * turnForceMultiplier * transform.right * x, ForceMode.VelocityChange);
            rb.AddForce(Time.fixedDeltaTime * forwardForceMultiplier * transform.forward * y, ForceMode.VelocityChange);
            if(x != 0)
            {
                Quaternion.Lerp(rb.rotation, Quaternion.Euler(Vector3.forward * turnFactor * -x),1f);
            }
        }
    }
}
