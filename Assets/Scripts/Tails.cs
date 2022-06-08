using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tails : MonoBehaviour
{
    public Text txt;
    public int tailsResult;
    public GameObject manager;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {

         txt.text = "Result: Tails!";
         tailsResult = 0;
         //Debug.Log("Tails.");
        
    }

}
