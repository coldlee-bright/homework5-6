using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float x1,y0,z0,y1,y2;
    public GameObject me;
    void Start()
    {

        y0 = transform.position.y;
        z0 = transform.position.z;

    }
    void LateUpdate()
    {

        x1 = me.transform.position.x;
        y1 = me.transform.position.y;
        y2 = transform.position.y;
        if (y2 - y1 < 15 && y2 - y1 > -15)
            transform.position = new Vector3(x1, y0, z0);
        else if(y2 - y1>=15)
        {
            transform.position = new Vector3(-2, 7, -14);
            y0 = 7;
        }
        else
        {
            transform.position = new Vector3(-2, 39, -14);
            y0 = 39;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
