using UnityEngine;

public class InstantiateFlower : MonoBehaviour
{
    public GameObject[] FlowerPrefabs;
    public GameObject flowerPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ground")
        {
            gameObject.transform.localScale = new Vector3(10, 10, 10);

            flowerPrefab = FlowerPrefabs[Random.Range(0, FlowerPrefabs.Length - 1)];
            flowerPrefab.SetActive(true);
            flowerPrefab.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.8f, gameObject.transform.position.z);

            Destroy(gameObject.GetComponent<MeshFilter>().mesh);
            Destroy(gameObject.GetComponent<Rigidbody>());
            Destroy(gameObject.GetComponent<SphereCollider>());
        }
    }
}
