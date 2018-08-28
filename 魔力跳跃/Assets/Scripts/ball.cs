using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    // Use this for initialization
    int i = 1, j = 0, k = 0, m = 0, n = 0, o = 1, p = 1, r = 1;
    int speed = 5;
    float x, z;
    public GameObject cube;
    public GameObject me;
    public Rigidbody2D r1;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "zhangai")
        {
            k = 1;
            m = 1;
        }
       
    }
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.transform.tag == "di")
            i = 0;
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.transform.tag == "di")
            i = 1;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "tiao")
        {
            j = 1;
        }
        if (col.transform.tag == "fzl")
        {
            n = 1 - n;
            o = -o;
        }
        if (col.transform.tag == "cs")
        {
            r = 0;
        }                  
    }
   private void Awake()
    {
       
    }
    public void siwang()
    {
        GetComponent<Rigidbody2D>().position = new Vector3(-12, 6, 2);
        m = 0;
        j = 0;
        i = 1;
        n = 0;
        o = 1;
    }
    void qianjin()
    {
        Physics2D.gravity = new Vector3(0, -60F, 0);
        GetComponent<Rigidbody2D>().AddForce(Vector3.right * 1, ForceMode2D.Impulse);
        if (GetComponent<Rigidbody2D>().velocity.x >= 10.2f)
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * 2, ForceMode2D.Impulse);
        if (j == 1)
        {
            r1.velocity = new Vector3(5f, 0, 0);
            GetComponent<Rigidbody2D>().AddForce(Physics2D.gravity * -19);
            j = 0;
            i = 2;
        }
        if (n == 1)
        {
            Physics2D.gravity = new Vector3(0, 55F, 0);
        }
        if (n == 0)
        {
            Physics2D.gravity = new Vector3(0, -55F, 0);
        }
        if (Input.GetButton("Fire1") && i == 0)
        {
            r1.velocity = new Vector3(5f, 0, 0);
            GetComponent<Rigidbody2D>().AddForce(Physics2D.gravity * -15);
            i = i + 1;
        }
    }
    void jingzhi()
    {
        Physics2D.gravity = new Vector3(0, 0, 0);
    }
    void chuansong()
    {
        GetComponent<Rigidbody2D>().position = new Vector3(-21, 37, 1);
    }
    // Update is called once per frame
    void Update()
    {
        if (k == 1||UI.c==0)
        {
            Invoke("siwang", 1);
            k = 0;
            UI.c = 1;
        }
        if (m == 1)
        {
            r1.velocity = new Vector3(0, 0, 0);
        }
        transform.Rotate(Vector3.back * 10*o);
        if (r == 0)
        {
            chuansong();
            r = 1;
        }

    }

    void FixedUpdate()
    {
        if (m==1)
        {
            jingzhi();
        }
        if (m == 0)
        {
            qianjin();
        }
    }

}