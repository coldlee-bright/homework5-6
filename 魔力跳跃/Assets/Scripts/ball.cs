using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
public class ball : MonoBehaviour
{

    // Use this for initialization
    int i = 1, j = 0, k = 0, m = 0, n = 0, o = 1, p = 1, r = 1;
    static public int time = 0;
    static public int w=1;
    int speed = 5;
    float x, z;
    public GameObject cube;
    public GameObject me;
    public Text text1;
    public GameObject camera2;
    public GameObject button1;
    public GameObject button2,button3,button4;
    public Rigidbody2D r1;
    public ArrayList listScore = new ArrayList();
    static public string names;
    public int score;
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
        if (col.transform.tag=="win")
        {
            w = 0;
        }
    }
   private void Awake()
    {
       
    }
    void jingzhi()
    {
        Physics2D.gravity = new Vector3(0, 0, 0);
    }
    void chuansong()
    {
        me.transform.position = new Vector3(-21, 37, 1);
        camera1.y0 = 39;
        camera2.transform.position = new Vector3(-2, 39, -14);
        
    }
    public void siwang()
    {
        GetComponent<Rigidbody2D>().position = new Vector3(-12, 6, 2);
        m = 0;
        j = 0;
        i = 1;
        n = 0;
        o = 1;
        time++;
        text1.text = ""+time;
        
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
        if (Input.GetButton("Fire1") && i == 0&&button.c==1)
        {
            r1.velocity = new Vector3(5f, 0, 0);
            GetComponent<Rigidbody2D>().AddForce(Physics2D.gravity * -15);
            i = i + 1;
        }
        if(button.c==0)
        {
            button.c = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (k == 1)
        {
            Invoke("siwang", 1);
            k = 0;
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
        if (w == 0)
        {
            chuansong();
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            w = 1;
            Cunchu();
            time = 0;
            text1.text = "" + time;
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
    void Cunchu()
    {
        const string savepath = "C:/Users/yyk/Desktop/3/homework5-6/魔力跳跃";
        string filename = "记录.txt";
        if (Directory.Exists(savepath))
            Debug.Log("存在目录");
        else
            Directory.CreateDirectory(savepath);
 //       StreamReader sr;
        StreamWriter sw;
 //       string nextline;
        FileInfo fi = new FileInfo(savepath + "/" + filename);
        if (!fi.Exists)
            sw = fi.CreateText();
        else
        {
            sw = fi.AppendText();
 //           sr = new StreamReader(savepath + "/" + filename);
        }
        sw.WriteLine(names+"  关卡"+choice.a+"死亡："+time);
        sw.Close();
        sw.Dispose();
    }
}