using UnityEngine;

public class Look : MonoBehaviour
{
    public Camera playerCamera;

    private Vector2 rotation = Vector2.zero;
    private float rotSpeed = 3;
    private void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        rotation.x = Mathf.Clamp(rotation.x, -15f, 15f);
        transform.eulerAngles = new Vector2(0, rotation.y) * rotSpeed;
        playerCamera.transform.localRotation = Quaternion.Euler(rotation.x * rotSpeed, 0, 0);
    }
}
