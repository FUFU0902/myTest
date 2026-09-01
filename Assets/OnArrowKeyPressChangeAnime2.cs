using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

public class OnArrowKeyPressChangeAnime2 : MonoBehaviour
{
    //-------------------------------------
    public string upAnime = "";
    public string downAnime = "";
    public string rightAnime = "";
    //-------------------------------------
    private string nowMode = "";
    private string oldMode = "";
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
        nowMode = downAnime;
    }

    public void Update(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>();

        if (moveInput.y > 0)
        {
            nowMode = upAnime;
        }
        else if (moveInput.y < 0)
        {
            nowMode = downAnime;
        }
        else if (moveInput.x != 0)
        {
            nowMode = rightAnime;

            if (nowMode != oldMode)
            {
                oldMode = nowMode;
                animator.Play(nowMode);
            }
        }

    }
}

