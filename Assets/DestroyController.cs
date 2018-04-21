using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {
   
    private GameObject myUnity;

    
	// Use this for initialization
	void Start () {
        this.myUnity = GameObject.Find("unitychan");

       
	}
	
	// Update is called once per frame
	void Update () {
        if (myUnity.transform.position.z >this.transform.position.z)
        {
            Destroy(gameObject,3.0f);
        }
	}
}
