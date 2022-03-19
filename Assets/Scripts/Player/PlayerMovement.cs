using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var inputX = Input.GetAxis("Horizontal");
        var inputZ = Input.GetAxis("Vertical");

        var movement = new Vector3(Speed * inputX, 0, Speed * inputZ);

        movement *= Time.deltaTime;
        transform.Translate(movement);
    }
}
