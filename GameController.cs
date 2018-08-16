using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public UnityEngine.UI.Text scoreLabel;
    public GameObject WinnnerLabelObject;
    

	// Update is called once per frame
	void Update () {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        if (count == 0)
        {
            WinnnerLabelObject.SetActive(true);
        }

       
    }

    
}
