using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trace : MonoBehaviour {

    public Transform target = null; // 추적할 위치 배열로 선언
    public float speed = 0; // 추적할 속도

    private void Update()
    {
        TargetTrace();
    }

    public void TargetTrace()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance < 0.3f)
            return;

        Vector3 dir = (target.position - transform.position).normalized;

        transform.position += dir * Time.smoothDeltaTime * speed;
    
    }

}
