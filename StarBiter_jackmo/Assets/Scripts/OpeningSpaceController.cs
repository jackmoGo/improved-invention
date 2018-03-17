using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningSpaceController : MonoBehaviour {

    public float scrollSpeedStar1 = 0.2f;
    public float scrollSpeedStar2 = 0.5f;
    public float scrollSpeedStar3 = 1f;

    const int MAX_STARS = 3;
    private GameObject[] stars = new GameObject[MAX_STARS];
    private float[] scrollSpeed = new float[MAX_STARS];

    private float bgZ1 = -10f;
    private float bgZ2 = 10f;

    private bool isEaseIn = false;
    private float easeInRate = 0.6f;

	// Use this for initialization
	void Start () {
        GameObject star1 = GameObject.FindGameObjectWithTag("Star1");
        GameObject star2 = GameObject.FindGameObjectWithTag("Star2");
        GameObject star3 = GameObject.FindGameObjectWithTag("Star3");
        stars[0] = star1;
        stars[1] = star2;
        stars[2] = star3;

        scrollSpeed[0] = scrollSpeedStar1;
        scrollSpeed[1] = scrollSpeedStar2;
        scrollSpeed[2] = scrollSpeedStar3;
	}

    void LateUpdate()
    {
        Scroll();
    }

    private void Scroll()
    {
        for (int i = 0; i < MAX_STARS; ++i)
        {
            if (!stars[i] || scrollSpeed[i] == 0)
            {
                continue;
            }

            Vector3 additionPos = new Vector3(0, 0, 1f) * scrollSpeed[i] * Time.deltaTime;
            stars[i].transform.position -= additionPos;

            IsOutOfWorld(stars[i]);
        }
    }

    private void IsOutOfWorld(GameObject star)
    {
        if (star.transform.position.z < bgZ1)
        {
            star.transform.position = new Vector3(
                star.transform.position.x,
                star.transform.position.y,
                bgZ2);
        }
    }
}
