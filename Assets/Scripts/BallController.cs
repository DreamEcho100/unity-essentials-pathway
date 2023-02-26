using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float forceMultiplier = 60f; // adjust this value to control the acceleration

    private Rigidbody rigidB;
    public Vector3 maxScaleChange = new Vector3(30f, 30f, 30f);
    public Vector3 scaleChange = new Vector3(0.0001f, 0.0001f, 0.0001f);

    void Start()
    {
        rigidB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // apply a gradually increasing force to the ball as it moves downward
        float force = rigidB.mass * Physics.gravity.magnitude * forceMultiplier;
        rigidB.AddForce(Vector3.down * force, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        if (
            transform.localScale.x >= maxScaleChange.x &&
            transform.localScale.y >= maxScaleChange.y &&
            transform.localScale.z >= maxScaleChange.z
            ) return;

        transform.localScale += scaleChange;

    }
}
