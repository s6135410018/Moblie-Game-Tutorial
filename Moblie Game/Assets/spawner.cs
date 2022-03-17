using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    float timeRelease = 0;
    float itemCycle = 0.5f;
    void Start()
    {
        itemCycle = Random.Range(0.5f, 2.0f);
    }

    void Update()
    {
        timeRelease += Time.deltaTime;
        if (timeRelease > itemCycle)
        {
            GameObject temp;
            temp = (GameObject)Instantiate(enemy);
            Vector3 pos = temp.transform.position;
            temp.transform.position = new Vector3(Random.Range(-16f,16f),Random.Range(1.6f,4f),pos.z);
            timeRelease -= itemCycle;
        }
    }
}
