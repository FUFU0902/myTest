using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ForeverChase2 : MonoBehaviour
{
	//-------------------------------------
	public GameObject targetObject;
	public float speed = 3;
	public bool ghostMode = false; Rigidbody2D rbody;

	void Start()
	{
		rbody = GetComponent<Rigidbody2D>();
		if (ghostMode)
		{
			rbody.bodyType = RigidbodyType2D.Kinematic;
		}
		else
		{
			rbody.gravityScale = 0;
			rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
		}
	}

	void FixedUpdate()
	{

		Vector3 dir = (targetObject.transform.position - transform.position).normalized;

		float vx = dir.x * speed;
		float vy = dir.y * speed;
		rbody.linearVelocity = new Vector2(vx, vy);
		GetComponent<SpriteRenderer>().flipX = (vx < 0);
	}
}
