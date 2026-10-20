using UnityEngine;
using UnityEngine.InputSystem;
public class OnMouseDownCreatePrefab2 : MonoBehaviour
{
    public GameObject newPrefab;

    public int newZ = -5;// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame)
        {
            Camera mainCamera = Camera.main;
            if (mainCamera == null || newPrefab == null)
                return;

            Vector2 screenPos = Pointer.current.position.ReadValue();
            float cameraDistance = Mathf.Abs(mainCamera.transform.position.z - newZ);
            Vector3 worldPos = mainCamera.ScreenToWorldPoint(
                new Vector3(screenPos.x, screenPos.y, cameraDistance));
            worldPos.z = newZ;

            Instantiate(newPrefab, worldPos, Quaternion.identity);
        }
    }
}
