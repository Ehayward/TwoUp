using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heads : MonoBehaviour
{
    public Text txt;
    public int headsResult;
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

    }

    public void OnTriggerExit(Collider other)
    {
        Landed = false;
    }

    public int Result()
    {
        if (Landed == true) 
        {
            headsResult = 1;

        }
        else
        {
            headsResult = 0;
        }
        return headsResult;
       


    }

}
