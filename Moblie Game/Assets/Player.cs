using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    CharacterController characterController;
    public float speed = 5.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    public FixedJoystick joystick;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // moveDirection = new Vector3(Input.GetAxis("Horizontal") * 10, Input.GetAxis("Vertical") * 10, 0.0f);
        moveDirection = new Vector3(joystick.Horizontal * 10, joystick.Vertical * 10, 0.0f);
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
}
