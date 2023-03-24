using UnityEngine;

public class LightReaction : MonoBehaviour
{
    private new Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (GetComponent<Light>().intensity > 0.5f)
        {
            renderer.material.color = Color.white;
        }
        else
        {
            renderer.material.color = Color.black;
        }
    }
}

