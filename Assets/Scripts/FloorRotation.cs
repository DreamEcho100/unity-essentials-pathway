using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRotation : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0f, 18f, 0f);

    private Vector3 rotationAngles;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up * rotationSpeed.y * Time.deltaTime);
        //transform.Rotate(Vector3.right * rotationSpeed.x * Time.deltaTime);
        //transform.Rotate(Vector3.forward * rotationSpeed.z * Time.deltaTime);

        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
