using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSpeed : MonoBehaviour
{
    [SerializeField]
    Vector3 speed;

    [SerializeField]
    KeyCode keyPos;

    [SerializeField]
    KeyCode keyNeg;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyPos)) GetComponent<Rigidbody>().velocity += speed;
        if (Input.GetKey(keyNeg)) GetComponent<Rigidbody>().velocity -= speed;

    }                                                                       
}
