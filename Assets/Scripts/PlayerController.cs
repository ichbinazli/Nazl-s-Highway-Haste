using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Degiskenler
    public float speed = 5.0f;
    public float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        // Oyuncu girisini alma
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Aracýn onune gecme
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Aracý cevirme
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
