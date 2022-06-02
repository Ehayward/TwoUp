using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heads : MonoBehaviour
{
    //public Text txt;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerStay(Collider Ground)
    {
        //txt.text = "Result: Heads!";
        Debug.Log("Heads.");
    }

}
