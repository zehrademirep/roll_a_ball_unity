using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrol : MonoBehaviour {

    public GameObject Ball;
    Vector3 Range;
	void Start ()
    {
        Range = transform.position - Ball.transform.position;
	}
	
	
	void LateUpdate ()
    {
        transform.position = Ball.transform.position + Range;
	}
}
