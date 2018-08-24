using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    // Use this for initialization
    int i = 1, j = 0, k = 0, m = 0, n = 0, o = 0, p = 1;
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
            o = 1;
        }
    }
   private void Awake()
    {
       
    }
     void siwang()
    {
        GetComponent<Rigidbody2D>().position = new Vector3(-12, 6, 2);
        m = 0;
        j = 0;
        i = 1;
        n = 0;
    }
    void qianjin()
    {
        Physics2D.gravity = new Vector3(0, -60F, 0);
        GetComponent<Rigidbody2D>().AddForce(Vector3.right * 1, ForceMode2D.Impulse);
        if (GetComponent<Rigidbody2D>().velocity.x >= 10)
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * 2, ForceMode2D.Impulse);
        if (j == 1)
        {
            r1.velocity = new Vector3(10, 0, 0);
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
            r1.velocity = new Vector3(10, 0, 0);
            GetComponent<Rigidbody2D>().AddForce(Physics2D.gravity * -15);
            i = i + 1;
        }
    }
    void jingzhi()
    {
        Physics2D.gravity = new Vector3(0, 0, 0);
    }
    void oo()

    {
        o = 0;
    }
    // Update is called once per frame
    void Update()
    {
       //float z=GetComponent<Rigidbody>().velocity.z;
        if (k == 1)
        {
            Invoke("siwang", 1);
            k = 0;
        }
        if (m == 1)
        {
            r1.velocity = new Vector3(0, 0, 0);
        }
        if (o == 1)
        {
            //transform.Rotate( Vector3.forward,10, Space.World);
            transform.rotation = Quaternion.Inverse(me.transform.rotation);
            o = 0;
        }
         

        /*x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, 0, z);
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(0, -250 * Time.deltaTime, 0,Space.Self);
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(0, 250 * Time.deltaTime, 0, Space.Self);
        x = Time.deltaTime * speed
        transform.Translate(x, 0, 0);*/
        /*if (j == 1)
            GameObject.Destroy(me);
        if (Input.GetKeyDown(KeyCode.C) && j == 1)
        {
            GameObject.Instantiate(me, transform.position, transform.rotation);
            j = 0;
        }*/
    }

    void FixedUpdate()
    {
        if(m==1)
        {
            jingzhi();
        }
        if (m == 0)
        {
            qianjin();
        }
        /*if (Input.GetButton("Fire1"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 15);
        }
        if (Input.GetButton("Fire2"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.down * 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 5);
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 5);
        }*/
    }

}