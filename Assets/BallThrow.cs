using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody ballRigid;

    public float throwForce;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            ThrowBall();
        }
    }

    void ThrowBall() 
    {
        ballRigid.velocity = Vector3.zero;
        ball.transform.position = transform.position;

        Vector3 throwingPower = throwForce * transform.forward;
        ballRigid.AddForce(throwingPower);
    }
}
