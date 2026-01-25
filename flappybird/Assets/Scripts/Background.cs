using UnityEngine;

public class Background : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; 
    public float animationSpeed = 0.05f;

    private void Awake()
    {
        // This looks for a 2D Sprite component instead of a 3D Mesh
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // This scrolls the actual position of the background 2D image
        transform.position += Vector3.left * animationSpeed * Time.deltaTime;

        // If the background goes too far left, loop it back to the right
        if (transform.position.x < -20f) { 
            transform.position += new Vector3(40f, 0, 0); 
        }
    }
}