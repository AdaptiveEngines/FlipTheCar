using UnityEngine;
using System.Collections;

public class BounceBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("worked");
        //other.transform.position = Vector3.Reflect(other.transform.position, Vector3.right);
    }
}
