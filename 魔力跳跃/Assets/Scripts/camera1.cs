using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera1 : MonoBehaviour
{
    float x1,z0,y1,y2;
    public GameObject me;
    static public float y0;
    /*public GameObject button1;
    public GameObject button2;*/
    void Start()
    {
        transform.position = new Vector3(-2, 39, -14);
        y0 = transform.position.y;
        z0 = transform.position.z;

    }
    void LateUpdate()
    {

        x1 = me.transform.position.x;
        y1 = me.transform.position.y;
        y2 = transform.position.y;


        /*if (y2 - y1 == 33)
        {
            transform.position = new Vector3(-2, 7, -14);
            y0 = 7;
        }
        else if ((int)(y1-y2)==29)
        {
            transform.position = new Vector3(-2, 39, -14);
            y0 = 39;
            button1.SetActive(true);
            button2.SetActive(true);
        }
        else*/
            transform.position = new Vector3(x1, y0, z0);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
