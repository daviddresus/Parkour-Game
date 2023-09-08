using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public float MoveUpSpeed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.up * MoveUpSpeed * Time.deltaTime);
    }
}
