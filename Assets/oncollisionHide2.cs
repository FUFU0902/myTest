using UnityEngine;

public class OnCollisionHide2 : MonoBehaviour
{
    //-------------------------------------
    public GameObject targetObject;
    public string tagName;
    public GameObject hideObject;
    //-------------------------------------

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject == targetObject ||
            collision.gameObject.tag == tagName)
        {
            hideObject.SetActive(false);
        }
    }
}