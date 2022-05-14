using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public float speed = 0;

    MeshRenderer render;

    private void Awake()
    {
        render = GetComponent<MeshRenderer>();        
    }

    private void Update()
    {
        render.material.mainTextureOffset += new Vector2(Time.deltaTime * speed,0);
    }
}

