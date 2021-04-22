using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerMovementTopDown : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public GameObject light;

    //public AudioSource warning;
    //public AudioSource torchStart;

    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    Vector3 velocity;
    public bool isGrounded;

    //void Update()
    //{
    //    isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

    //    if(isGrounded && velocity.y < 0)
    //    {
    //        velocity.y = -2f;
    //    }

    //    float x = Input.GetAxis("Horizontal");
    //    float z = Input.GetAxis("Vertical");

    //    if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
    //    {
    //        Debug.Log("Jump");
    //        gameObject.transform.Translate(0, 0.1f, 0);
    //    }

    //    Vector3 move = transform.right * x + transform.forward * z;

    //    controller.Move(move * speed * Time.deltaTime);

    //    velocity.y += gravity * Time.deltaTime;

    //    controller.Move(velocity * Time.deltaTime);

    //    if (Input.GetKeyDown(KeyCode.Q))
    //    {
    //        StartCoroutine(PlayerLight());
    //    }
    //}

    IEnumerator PlayerLight()
    {
        //torchStart.Play();
        light.SetActive(true);
        yield return new WaitForSeconds(10f);
        //warning.Play();
        light.SetActive(false);
        timeRemaining = 10;
    }

}
