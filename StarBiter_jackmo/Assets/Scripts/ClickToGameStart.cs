using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToGameStart : MonoBehaviour {

    private GameObject mainCamera;

	// Use this for initialization
	void Start () {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            mainCamera.GetComponent<AudioSource>().Play();
            Application.LoadLevel("game");
        }
	}
}
