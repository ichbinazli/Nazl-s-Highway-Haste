using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour
{
    //Oyun nesnesi degiskeni.
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -10);

    // Update is called once per frame
    void LateUpdate()
    {
        //Pozisyon ekleyerek oyuncunun arkas�ndaki kameray� dengeledim.
        transform.position = player.transform.position + offset;
    }
}
