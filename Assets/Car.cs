   `using UnityEngine;

// A simple 2D movement controller for a player in Unity
public class PlayerMovementController : MonoBehaviour
{
    Gameplay properties 

    // Horizontal player keyboard imput 
    //  -1 = Left 
    //  0 = No imput 
    // = Right 
    private float playerImput = 0 ;

    // Horizontal player speed 
    [SerializeField] private float speed = 250;

    Component references 

    private Rigidbody2D rb;

    // Initialisation methods 

    // Initiales this component 
    // (NB: Is called automaticaly before the first frame update)
    void Awake ()
    {
        // Instante player car 
        playerCarInstance = Instantiate (PlayerCarPrefab, Vector.zero, Quaternion.identity);

        // Instantiate track
        trackInstance = Instantiate(TrackPrefab, Vector3.zero, Quaternion.identity);
    }
}
void Start()
{
    // Get component references 
    rb = GetComponent<Rigidbody2D>();
}
Gameplay methods 

// Is called automaticaly every graphics frame 
void update()
{
    // Detect and store horizontal player input
    playerInput.GetAxisRaw("Horizontal");

    // NB: Here, you might want to set the player's animation,
    // e.g. idle or walking 

    // swap the player sprite scale to the face the movement direction 
    SwapSprite();
}
// Swap the player sprite scale to the face the movement direction
void SwapSprite()
{
    // Right 
    if (playerImput > 0)
    {
        transform.localScale = new Vector3(
            Math.abs(transform.localScale.x),
            transform.localScale.y,
            transform.localScale.z,


        );
    }
}
// Is called automaticaly every physyc step 
void FixedUpdate()
{
    // Move the player horizontally 
    rb.velocity = new Vector2(
        playerInput * speed * Time.fixedDeltaTime,
        0
    );
}