using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ilk hýz degiskenim
    public float speed = 5.0f;

    private void Awake()
    {
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // aracý ileri haraket ettir
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
