using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tails : MonoBehaviour
{
    public Text txt;
    public int tailsResult;
    bool Landed = false;

    public SoundManager soundManager;

    public GameObject coinCarrier;
    static Rigidbody coin;
    public static Vector3 coinVelocity;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Table")
        {
            soundManager.coins.clip = soundManager.coinCollide;
            soundManager.coins.Play();
        }
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
            tailsResult = 0;

        }
        else
        {

        }
        return tailsResult;

    }

}
