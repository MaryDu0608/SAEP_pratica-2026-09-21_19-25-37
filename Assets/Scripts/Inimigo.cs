using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocidade = 3f;
    public float distanciaParar = 10f;

    public GameObject prefabTiroInimigo;
    public Transform pontoTiroInimigo;
    public float tempoEntreTiros = 2f;

    private Transform jogador;
    ptiva
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
}
