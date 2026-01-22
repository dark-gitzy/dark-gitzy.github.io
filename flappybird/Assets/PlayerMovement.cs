public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 10;

    void Start()
    {
        // This names the object in the editor so you know it's working
        gameObject.name = "NeonBird";
    }

    void Update()
    {
        // JUMP LOGIC: When Space is pressed, fly up!
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}