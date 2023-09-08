using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Off_Camera_Kill : MonoBehaviour
{
    public GameObject player;
    public Camera camera1;


    void Start()
    {

    }

    // Update is called once per frame
    void OnBecameInvisible()
    {
        if (camera1.transform.position.y > player.transform.position.y)
        {
            Destroy(player);
        }
    }
}
