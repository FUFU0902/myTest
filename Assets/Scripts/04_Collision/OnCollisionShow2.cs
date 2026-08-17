using System.Collections2;
using System.Collections2.Generic;
using UnityEngine;

// 衝突すると、表示する
public class OnCollisionShow2 : MonoBehaviour
{
	//-------------------------------------
	public GameObject targetObject;
	public string tagName;
	public GameObject showObject;
	//-------------------------------------

	void Start()
	{
		showObject.SetActive(false);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject == targetObject ||
			collision.gameObject.tag == tagName)
		{
			showObject.SetActive(true); // 表示する
		}
	}
}
