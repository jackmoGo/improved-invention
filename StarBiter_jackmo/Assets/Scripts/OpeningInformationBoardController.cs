using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningInformationBoardController : MonoBehaviour {

    public float scrollSpeed = 0.2f;
    public float startPosition = -0.2f;

    private float stopPositionY;
    private GameObject informationBoard;


	// Use this for initialization
	void Start () {
        informationBoard = GameObject.FindGameObjectWithTag("InformationBoard");
        stopPositionY = informationBoard.transform.position.y;
        Vector3 tmpPosition = informationBoard.transform.position;
        informationBoard.transform.position = new Vector3(tmpPosition.x, startPosition, tmpPosition.z);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = informationBoard.transform.position;
        if (position.y < stopPositionY)
        {
            position.y += scrollSpeed * Time.deltaTime;
            informationBoard.transform.position = new Vector3(position.x, position.y, position.z);
        }
	}
}
