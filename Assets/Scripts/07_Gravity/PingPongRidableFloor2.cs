using System.Collections.Generic;
using UnityEngine;

public class PingPongRidableFloor2 : MonoBehaviour
{
    public float speed = 1.0f;
    public float moveTime = 2.0f;

    private Rigidbody2D rbody;
    private float timer = 0.0f;
    private readonly List<GameObject> childObjects = new List<GameObject>();


    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();
        rbody.bodyType = RigidbodyType2D.Kinematic;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= moveTime)
        {
            speed = -speed;
            timer = 0.0f;
        }

        CheckRemove();
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == null)
            return;

        if (!childObjects.Contains(other.gameObject))
        {
            childObjects.Add(other.gameObject);
        }

        other.gameObject.transform.SetParent(transform, true);
    }

    private void CheckRemove()
    {
        List<GameObject> removeList = new List<GameObject>();
        foreach (GameObject obj in childObjects)
        {
            if (obj == null)
            {
                removeList.Add(obj);
                continue;
            }

            Collider2D childCol = obj.GetComponent<Collider2D>();
            Collider2D floorCol = GetComponent<Collider2D>();
            if (childCol == null || floorCol == null || !Physics2D.IsTouching(childCol, floorCol))
            {
                obj.transform.SetParent(null, true);
                removeList.Add(obj);
            }
        }

        foreach (GameObject obj in removeList)
        {
            childObjects.Remove(obj);
        }
    }
}