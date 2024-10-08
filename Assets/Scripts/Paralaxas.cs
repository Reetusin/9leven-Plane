using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralaxas : MonoBehaviour
{
    public float speed = -0.5f;

    private Renderer rend;

    private Vector2 offset;



    void Start()
    {
        rend = GetComponent<Renderer>();
        offset = rend.material.mainTextureOffset;
    }

    void Update()
    {
        offset.x += Time.deltaTime * speed;
        rend.material.mainTextureOffset = offset;
    }
}
