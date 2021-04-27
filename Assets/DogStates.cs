using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dropAndWait : State 
{
    
}

public class fetch : State 
{
    public override void Enter()
    {
        owner.GetComponent<Seek>().enabled = true;
    }

    public override void Think()
    {
        if (Vector3.Distance(owner.transform.position, GameObject.Find("Ball").transform.position) < 10) 
        {
            GameObject.Find("Ball").transform.parent = owner.transform.Find("ballAttach");
            owner.ChangeState(new returnBall());
        }
    }

    public override void Exit()
    {
        owner.GetComponent<Seek>().enabled = false;
    }


}

public class returnBall : State
{
    public override void Enter()
    {
        owner.GetComponent<Seek>().enabled = true;
        owner.GetComponent<Seek>().targetGameObject = GameObject.Find("Main Camera");
    }

    public override void Think()
    {
        if (Vector3.Distance(owner.transform.position, GameObject.Find("Main Camera").transform.position) < 10)
        {
            GameObject.Find("Ball").transform.parent = null;
            owner.ChangeState(new dropAndWait());
        }
    }

    public override void Exit()
    {
        owner.GetComponent<Seek>().enabled = false;
    }


}

public class DogStates : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
