using UnityEngine;

public class CameraManager2 : MonoBehaviour
{
    public GameObject player;
    public Vector2 offset;
    public float xlimit = 0;
    public bool followHOnly = true;
    public bool smoothFollow = false;
    public float smoothSpeed = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void LateUpdate2()
    {
        if (player == null) return;
        Vector3 playerPos = player.transform.position;
        Vector3 desiredPos;
        float vx = playerPos.x + offset.x;
        float vz = transform.position.z;
        if (vx < xlimit) vx = xlimit;
        if (followHOnly)
        {
            desiredPos = new Vector3(vx, transform.position.y, vz);
        }
        else
        {
            desiredPos = new Vector3(vx, playerPos.y + offset.y, vx);
        }
        if (smoothFollow)
        {
            Vector3 smoothedPos = Vector3.Lerp(transform.position,
            desiredPos, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPos;
        }
        else
        {
            transform.parent.position = desiredPos;
        }
    }
}




// Update is called once per frame

