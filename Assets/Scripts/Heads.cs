using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heads : MonoBehaviour
{
    public Text txt;
    public int headsResult;

    void Start()
    {
        
    }

    void Update()
    {
  
    }

    void OnTriggerStay(Collider other)
    {
        txt.text = "Result: Heads!";
        //Debug.Log("Heads.");
        headsResult = 1;
    }

}
