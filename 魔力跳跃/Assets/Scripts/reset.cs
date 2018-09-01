using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public Text text;
    public void Click()
    {
        ball.names = text.text;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
