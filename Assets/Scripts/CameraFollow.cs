using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject coin;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - coin.transform.position;
    }

    void Update()
    {
        transform.position = coin.transform.position + offset;
    }
}
