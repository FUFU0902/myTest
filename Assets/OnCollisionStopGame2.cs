using UnityEngine;

public class OnCollisionStopGame : MonoBehaviour
{
    //-------------------------------------
    public GameObject targetObject;
    public string tagName;
    //-------------------------------------

    void Start()
    {
        Time.timeScale = 1;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject == targetObject ||
            collision.gameObject.tag == tagName)
        {
            Time.timeScale = 0;
        }
    }
}

