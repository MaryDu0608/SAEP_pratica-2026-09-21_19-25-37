using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    public float speed = 5f;
    public int vidaAtual;
    public int vidaMaxima = 5;
    private Vector3 pontoOrigem;
    
    [SerializeField] public AudioClip somDano; 
   
    private AudioSource audioSource;
    public GameObject telapause;
    
    private Rigidbody2D physicsPlayer;
    public HudVida hudVida;
    private SpriteRenderer spriteRenderer;
    private Collider2D playerCollider;
    public bool paused;
    


    void Start()
    {
        pontoOrigem = transform.position;
        vidaAtual = vidaMaxima;

        spriteRenderer = GetComponent<SpriteRenderer>();
        playerCollider = GetComponent<Collider2D>();
        physicsPlayer = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        physicsPlayer.linearVelocity = new Vector2(horizontalInput * speed, verticalInput * speed);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool paused = !telapause.activeSelf;

            telapause.SetActive(paused);

            
            if (paused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
        

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
        hudVida.AtualizarHud(vidaAtual);
        TocarSomDano(somDano);

        Debug.Log("Player tomou dano! Vida restante: " + vidaAtual);

        if (vidaAtual <= 0)
        {
            TocarSomDano(somDano);
            SceneManager.LoadScene("Derrota");

        }
    }

    public void TocarSomDano(AudioClip somDano)
    {
        
        if (somDano != null && audioSource != null)
        {
            audioSource.clip = somDano;
            audioSource.Play();
        }

    }

   





}
