using UnityEngine;

public class AtaqueGuiado : MonoBehaviour
{
    public float velocidade = 3f;
    private Transform jogador;
    public float tempoVida = 2f;
    void Start()
    {
        GameObject jogadorObj = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject, tempoVida);

        if (jogadorObj != null)
        {
           jogador = jogadorObj.transform;
            
        }

        
    }

    
    void Update()
    {
        if (jogador != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, jogador.position, velocidade * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            Destroy(gameObject);
            
        }
    }
}
