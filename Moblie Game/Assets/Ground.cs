using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = 0.5f;

    void Update()
    {
        float offset = Time.time * speed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, -offset);
    }
}
