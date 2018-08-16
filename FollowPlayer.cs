using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform target;

    private Vector3 offset;

    // Update is called once per frame

    private void Start()
    {
        offset = GetComponent<Transform>().position - target.position;
    }

    void Update () {

        GetComponent < Transform >().position= target.position+offset;
	}
}
