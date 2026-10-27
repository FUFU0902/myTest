using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

public class OnKeyPressMove2 : MonoBehaviour
{
    //-------------------------------------
    public float speed = 5f;
    //-------------------------------------
    private Vector2 moveInput;
    private Rigidbody2D rbody;
    private SpriteRenderer sr;

    void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        rbody.gravityScale = 0;

        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
