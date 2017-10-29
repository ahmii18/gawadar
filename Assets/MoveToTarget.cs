using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{

    public GameObject target;
    Vector3 position;
    Vector3 rotation;
    public float cspeed = 10f;
    public float Rspeed = 100f;
    //[x,yz]
    // Use this for initialization
    void Start()
    {
        position = target.transform.position;
        rotation = target.transform.rotation;
        transform.Rotate(rotation, Rspeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

        while (transform.Position != position)
        {
            transform.Translate(Vector3.forward * cspeed * Time.deltaTime);
        }
    }
}



