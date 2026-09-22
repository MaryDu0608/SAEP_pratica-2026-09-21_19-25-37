using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocidade = 3f;
    public float distanciaParar = 10f;
    public int vidaMaximalInimigo = 3;
    public int vidaAtualInimigo;

    public GameObject prefabTiroInimigo;
    public Transform pontoTiroInimigo;
    public float intervaloTiro = 2f;

    private Transform jogador;
    private float cronometro;
    void Start()
    {
        GameObject jogadorObj = GameObject.FindGameObjectWithTag("Player");
        if (jogadorObj != null)
        {
            jogador = jogadorObj.transform;
        }
    }

    
    void Update()
    {
        MoveInimigo();
        cronometro += Time.deltaTime;

        if (cronometro >= intervaloTiro)
        {
            Atirar();
            cronometro = 0f;
        }

        vidaAtualInimigo = vidaMaximalInimigo;
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bala"))
        {
            ReceberDano();

        }
    }

    public void MoveInimigo ()
    {
        if (jogador == null) return;

        float distanciahorizontal = transform.position.x - jogador.position.x;

        if (distanciahorizontal > distanciaParar)
        {

            transform.Translate(Vector3.left * velocidade * Time.deltaTime, Space.World);

        }
    }

    void Atirar()
    {
        if (prefabTiroInimigo != null && pontoTiroInimigo != null)
        {
            Instantiate(prefabTiroInimigo, pontoTiroInimigo.position, Quaternion.identity);


        }
    }

    void ReceberDano()
    {
        vidaAtualInimigo--;
        Debug.Log("Recebeu dano, vida atual " +  vidaAtualInimigo);

        if (vidaAtualInimigo <= 0)
        {
            Destroy(gameObject);

        }
    }
}
