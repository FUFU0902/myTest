using UnityEngine;

public class OnKeyPressMove2 : MonoBehaviour
{

    public float speed = 5f;
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

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();

        if (moveInput.x != 0) sr.flipX = moveInput.x < 0;
    }

    void FixedUpdate()
    {

        rbody.linearVelocity = moveInput * speed;
    }
}

public class InputValue
{
}