using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameLogic : MonoBehaviour
{
    public int hp = 5;

    void Update()
    {
        if (hp < 0)
        {
            hp = 0;
            SceneManager.LoadScene("Finish", LoadSceneMode.Single);
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "bullet")
        {
            hp -= 1;
        }
    }
}
