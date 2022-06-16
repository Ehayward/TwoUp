using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flip : MonoBehaviour
{
    Flip2 flip2;
    static Rigidbody coin;
    private static Vector3 coinVelocity;

    public GameObject flipButton;
    public GameObject bettingManager;
    public GameObject coinself;

    //coin2 details
    public GameObject coin2;
    static Rigidbody coin2rb;
    public static Vector3 coin2Velocity;

    bool flipped = false;

    void Start()
    {
        coin = GetComponent<Rigidbody>();
        coin2rb = coin2.GetComponent<Rigidbody>();
    }

    public void cointoss()
    {
        //KeyCode assigns which key gets pressed to trigger the "flip", the && means you cannot press while the vector3 velocity is >
        if ((coinVelocity[0] == 0) && (coinVelocity[1] == 0) && (coinVelocity[2] == 0))
        {
            //This sets the power of spin you would like and what direction.
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(110, 300);

            //This is the coin's starting position and rotation.
            transform.position = new Vector3(0, 2, 0);

            //Quaternion = rotation values
            transform.rotation = Quaternion.identity;

            //This sets the force that it will send the coin upward.
            coin.AddForce(transform.up * 750);
            coin.AddTorque(dirX, dirY, dirZ);
        }
        flipButton.gameObject.SetActive(false);
    }

    void Update()
    {
        coinVelocity = coin.velocity;
        coin2Velocity = coin2rb.velocity;

        if (this.transform.position.y > 5)
        {
            flipped = true;
        }

        if ((coinVelocity[0] == 0) && (coinVelocity[1] == 0) && (coinVelocity[2] == 0) && flipped == true && (coin2Velocity[0] == 0) && (coin2Velocity[1] == 0) && (coin2Velocity[2] == 0))
        {
            bettingManager.GetComponent<BettingGameManager>().ResultsScreen();
            flipped = false;
        }
       
    }
}
