using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
	public Rigidbody2D rb;
	Vector3 previousPostion;
	Vector3 mousePosWorld2D;
	Vector3 velocity;
	float speed=2000;
	
	private void Start()
    	{
		rb = GetComponent<Rigidbody2D>();
	}
	void OnMouseDrag()
	{
		previousPostion = rb.position;
		Vector3 mousePoint = Input.mousePosition;
		Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePoint);
		mousePosWorld2D = new Vector3(mousePosWorld.x, mousePosWorld.y, 0);
		velocity = (mousePosWorld2D - previousPostion) * Time.deltaTime*speed;
	}
	void OnMouseUp()
    	{
		velocity = Vector3.zero;
    	}

	void FixedUpdate()
    	{
		rb.velocity = velocity;
	}
}
