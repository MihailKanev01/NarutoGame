using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 3, -6);
    public float smoothSpeed = 10f;

    public float mouseSensitivity = 100f;
    private float xRotation = 0f;

    void LateUpdate()
    {
        if (target == null) return;

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -35f, 60f);

        transform.position = target.position + offset;
        transform.RotateAround(target.position, Vector3.up, mouseX);
        Quaternion rotation = Quaternion.Euler(xRotation, transform.eulerAngles.y, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, smoothSpeed * Time.deltaTime);
    }
}