using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float x1,y0,z0;
    public GameObject me;
    void Start()
    {

        y0 = transform.position.y;
        z0 = transform.position.z;

    }
    void LateUpdate()
    {
        x1 = me.transform.position.x;
        transform.position = new Vector3(x1, y0,z0);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
