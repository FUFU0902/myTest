using UnityEngine;
using UnityEngine.InputSystem;
public class OnMouseDownHide2 : MonoBehaviour
{
  // aaa


  void Update()
  {
    if (Mouse.current.leftButton.wasPressedThisFrame)

    {
      var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
      var hit = Physics2D.GetRayIntersection(ray, 100f, 1 << gameObject.layer);
      if (hit.collider && hit.collider.gameObject == gameObject)
      {
        gameObject.SetActive(false);
      }
    }
  }
}


