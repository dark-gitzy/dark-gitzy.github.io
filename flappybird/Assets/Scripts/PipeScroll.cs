using UnityEngine;

public class PipeScroll : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 3f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime ;

        if(transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
