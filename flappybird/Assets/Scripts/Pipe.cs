using UnityEngine;

public class Pipe : MonoBehaviour
{
    public GameObject Pipes;
    public float spwanRate = 1f;
    public float maxHeight = 1f;
    public float minHeight = -1f;

    private void OnEnable()
    {
        InvokeRepeating (nameof(Spawn), spwanRate, spwanRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject PipePair = Instantiate(Pipes, transform.position, Quaternion.identity);
        PipePair.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
