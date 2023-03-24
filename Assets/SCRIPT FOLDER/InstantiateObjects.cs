using UnityEngine;

public class InstantiateObjects : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfObjects = 100;
    public float radius = 5f;

    private void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Calculate a random position on the surface of a sphere with radius "radius"
            Vector3 position = Random.onUnitSphere * radius;

            // Instantiate the prefab at the calculated position
            GameObject obj = Instantiate(prefab, position, Quaternion.identity);

            // Change the color of the instantiated object to a random color
            Renderer renderer = obj.GetComponent<Renderer>();
            renderer.material.color = Random.ColorHSV();
        }
    }
}


