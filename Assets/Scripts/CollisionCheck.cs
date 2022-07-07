using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public SoundManager soundManager;

    private void Start()
    {

    }
    void Update()
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.transform.tag == "Coin" || other.gameObject.transform.tag == "Coin2Self")
            {
                Debug.Log("Bang");
                soundManager.coins.clip = soundManager.coinFlip;
                soundManager.coins.Play();
            }
        }
    }

}
