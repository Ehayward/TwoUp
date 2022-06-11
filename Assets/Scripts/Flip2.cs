using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip2 : MonoBehaviour
{
    static Rigidbody coin;
    public static Vector3 coinVelocity;
    

    void Start()
    {

    }

    public void cointoss()
    {
        coin = GetComponent<Rigidbody>();
        coinVelocity = coin.velocity;

        //KeyCode assigns which key gets pressed to trigger the "flip", the && means you cannot press while the vector3 velocity is >
        if ((coinVelocity[0] == 0) && (coinVelocity[1] == 0) && (coinVelocity[2] == 0))
        {
            //This sets the power of spin you would like and what direction.
            float dirX = Random.Range(250, 700);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(200, 900);

            //This is the coin's starting position and rotation.
            transform.position = new Vector3(1, 2, 0);

            //Quaternion = rotation values
            transform.rotation = Quaternion.identity;

            //This sets the force that it will send the coin upward.
            coin.AddForce(transform.up * 750);
            coin.AddTorque(dirX, dirY, dirZ);
        }

    }
    void Update()
    {

    }
}
