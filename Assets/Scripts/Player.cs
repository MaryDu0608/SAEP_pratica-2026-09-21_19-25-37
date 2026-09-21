using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    public float speed = 5f;
    private int vidaAtual;
    public int vidaMaxima = 5;

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

        vidaAtual = vidaMaxima;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TiroInimigo"))
        {
            Dano();

        }
    }

    public void Dano()
    {
        vidaAtual--;
        Debug.Log("Player tomou dano! Vida restante: " + vidaAtual);

        if (vidaAtual <= 0)
        {
            Destroy(gameObject);

        }
    }



}
