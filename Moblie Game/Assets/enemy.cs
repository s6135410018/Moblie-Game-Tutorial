using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float objectSpeed = 0.2f;
    void Update()
    {
         transform.Translate(0,0,objectSpeed);
        // objectSpeed คือทิศทางของลูกศรสีน้ำเงิน
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
