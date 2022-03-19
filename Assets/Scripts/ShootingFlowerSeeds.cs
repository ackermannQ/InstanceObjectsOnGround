using UnityEngine;

public class ShootingFlowerSeeds : MonoBehaviour
{
    public GameObject FlowerSeedPrefab;
    public GameObject FlowerShooter;

    private readonly float shootingSpeed = 8f;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateFlowerSeeds(FlowerSeedPrefab);
        }
    }

    private void CreateFlowerSeeds(GameObject prefab)
    {
        var newGameObject = Instantiate(prefab, transform.position + Vector3.right, Quaternion.identity);
        newGameObject.GetComponent<SphereCollider>().isTrigger = true;

        var rb = newGameObject.AddComponent<Rigidbody>();
        rb.position = new Vector3(rb.position.x, rb.position.y, rb.position.z);

        if (!rb)
        {
            return;
        }

        rb.velocity = FlowerShooter.transform.forward * shootingSpeed;
    }
}
