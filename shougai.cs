using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shougai : MonoBehaviour {

    public GameObject LoserLabelObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision shougai)
    {
        if (shougai.gameObject.CompareTag("shougai"))
        {
            LoserLabelObject.SetActive(true);

        }
    }
}
