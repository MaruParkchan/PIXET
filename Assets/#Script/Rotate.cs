using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float wheelSpeed = 0;

    private void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * wheelSpeed);
    }
}
