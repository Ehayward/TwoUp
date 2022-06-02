using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Side : MonoBehaviour
{
    public Text txt;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        txt.text = "Result: Side...";
        //Debug.Log("Heads.");
    }

}