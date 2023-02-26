using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDecline : MonoBehaviour
{
    public Vector3 positionChange = new Vector3(0f, 50f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 500) return;
        transform.position -= positionChange * Time.deltaTime;
    }
}
