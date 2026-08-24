using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

// キーを押すと、スプライトが移動する
public class OnKeyPressMoveSprite : MonoBehaviour
{
    //-------------------------------------
    public float speed = 5f; //［速度］
                             //-------------------------------------
    private Vector2 currentMoveInput;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnMove(InputValue value)
    {
        currentMoveInput = value.Get<Vector2>();
        // 移動方向にキャラを向ける
        if (currentMoveInput.x != 0) spriteRenderer.flipX = currentMoveInput.x < 0;
    }

    void FixedUpdate()
    {
        // 位置を直接更新して移動
        Vector2 delta = currentMoveInput * speed * Time.fixedDeltaTime;
        transform.Translate(delta.x, delta.y, 0);
    }
}
