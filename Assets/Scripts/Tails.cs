using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tails : MonoBehaviour
{
    public Text txt;
    public int tailsResult;
    bool Landed = false;

    public GameObject coinCarrier;
    static Rigidbody coin;
    public static Vector3 coinVelocity;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        Landed = true;
        txt.text = "Result: Tails!";

         //Debug.Log("Tails.");    
    }
    public void OnTriggerExit(Collider other)
    {
        Landed = false;
    }

    public void Result()
    {
        if (Landed == true) 
        {
            tailsResult = 0;
            Debug.Log(tailsResult);
        }
        else
        {

        }


    }

}
