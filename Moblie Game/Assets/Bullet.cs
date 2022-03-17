using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 0.7f;
    public float secondDestroy = 2.0f;
    float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        this.gameObject.transform.position += speed * this.gameObject.transform.forward;
        if (Time.time - startTime >= secondDestroy)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
