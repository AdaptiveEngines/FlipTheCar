using UnityEngine;
using System.Collections;

public class flip : MonoBehaviour {
    Vector2 touchBegin;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.anyKeyDown)
        {
            Debug.Log("working");
            float randomX = Random.Range(-20, 20);
            float randomY = Random.Range(-20, 20);
            float randomZ = Random.Range(-10, 20);
            Vector3 force = new Vector3(randomX,randomY,randomZ);
            GetComponent<Rigidbody>().AddForceAtPosition(force, GetComponent<Transform>().position, ForceMode.Impulse);

        }



        if (Input.touchCount == 1 && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Debug.Log("touched");
            touchBegin = Input.GetTouch(0).position;
        }
       if (Input.touchCount == 1 && (Input.GetTouch(0).phase == TouchPhase.Ended))
        {
            Vector2 touchEnd = Input.GetTouch(0).position;
            Vector2 difference = touchBegin - touchEnd;
            Vector2 convert= difference.normalized;
            // Vector3 force = new Vector3(difference.x, difference.y, 0);
            Vector3 force = new Vector3(3, 4, 5);
            GetComponent<Rigidbody>().AddForceAtPosition(force, GetComponent<Transform>().position, ForceMode.Impulse);
        }
    }
}

