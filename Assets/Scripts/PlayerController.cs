using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ilk h�z degiskenim
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
        // arac� ileri haraket ettir
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
