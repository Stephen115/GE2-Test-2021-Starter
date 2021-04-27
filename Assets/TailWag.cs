using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailWag : MonoBehaviour
{
    public GameObject pivot;

    float MaxAngleDeflection = 40.0f;
    float SpeedOfPendulum = 30.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float angle = MaxAngleDeflection * Mathf.Sin(Time.time * SpeedOfPendulum);
        pivot.transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
}
