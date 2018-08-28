using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {
    public GameObject me;    
    static public int c = 1;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(-2, 39, -14);

    }
	
	// Update is called once per frame
	void Update () {
    }
    public void OnGUI()
    {
        GUIStyle fontStyle = new GUIStyle();
        fontStyle.normal.background = null;
        fontStyle.normal.textColor = new Color(1, 0, 0);
        fontStyle.fontSize = 50;
        GUI.backgroundColor = Color.blue;
        if (transform.position.y>30)
        {
            if (GUI.Button(new Rect(420, 150, 100, 40), "开始游戏"))
            {
                //me.transform.position = new Vector3(-12, 6, 2);
                c = 0;
            }
        }
       	
            
    }
}
