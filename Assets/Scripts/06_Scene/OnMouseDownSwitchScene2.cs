
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class OnMouseDownSwitchScene2 : MonoBehaviour
{
    public string sceneName;

    private string GetSceneName1()
    {
        return sceneName;
    }

    void Update()
    {

        if (Camera.main == null)
        {
            return;
        }

        var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        var hit = Physics2D.GetRayIntersection(ray, 100f, 1 << gameObject.layer);
        if (hit.collider != null && hit.collider.gameObject == gameObject)
        {
            SceneManager.LoadScene(sceneName: GetSceneName1());
        }
    }
}

