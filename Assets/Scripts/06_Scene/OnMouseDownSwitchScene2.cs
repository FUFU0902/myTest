using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

// マウスでクリックしたら、シーンを切り替える
public class OnMouseDownSwitchScene2 : MonoBehaviour
{
    public string sceneName;

    private string GetSceneName1()
    {
        return sceneName;
    }

    void Update(string sceneName1)
    {

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            var hit = Physics2D.GetRayIntersection(ray, 100f, 1 << gameObject.layer);
            if (hit.collider && hit.collider.gameObject == gameObject)
            {
                SceneManager.LoadScene(sceneName: sceneName1);
            }
        }
    }
}
