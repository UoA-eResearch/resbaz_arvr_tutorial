using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class BallSpawner : MonoBehaviour {

	GestureRecognizer recognizer;
	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
		recognizer = new GestureRecognizer();
		recognizer.Tapped += Recognizer_Tapped;
		recognizer.StartCapturingGestures();
	}

	private void Recognizer_Tapped(TappedEventArgs obj)
	{
		Debug.Log("tap");
		var ball = Instantiate(ballPrefab);
		ball.GetComponent<Renderer>().material.color = Random.ColorHSV();
		ball.transform.position = Camera.main.transform.position + Camera.main.transform.forward;
		ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 1000);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
