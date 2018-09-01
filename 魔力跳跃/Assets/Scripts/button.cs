using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
    public GameObject camera2;
    static public int c = 0;
    public GameObject button1;
    public GameObject button2,button3,button4;
    public GameObject Me;
    public Text text1;
    public void guanqia1()
    {
        Me.transform.position = new Vector3(-12, 6, 2);
        camera1.y0 = 7;
        camera2.transform.position = new Vector3(-2, 7, -14);
    }
	public void Click()
    {
        //Debug.Log("3.1415926");
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        text1.text = "" + ball.time;
        if (choice.a == 0)
            Invoke("guanqia1", 1);
        c = 1;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
