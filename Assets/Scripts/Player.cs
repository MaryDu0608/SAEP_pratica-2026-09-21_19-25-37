using UnityEngine;

public class Player : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    public float speed = 5f;
    private Rigidbody2D physicsPlayer;


    void Start()
    {
        physicsPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        physicsPlayer.linearVelocity = new Vector2(horizontalInput * speed, verticalInput * speed);

        
    }

    


}
