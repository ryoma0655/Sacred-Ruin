using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaiten : MonoBehaviour {
	public float z=10;
	public float angle = 10;
	public GameObject Shot;
	void Start () {
			Instantiate (Shot, transform.position, transform.rotation);
	}
		
	// Startメソッドをコルーチンとして呼び出す
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime, Space.World);
	}
}
