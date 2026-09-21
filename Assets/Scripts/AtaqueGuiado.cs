using UnityEngine;

public class AtaqueGuiado : MonoBehaviour
{
    public float velocidade = 3f;
    private Transform jogador;
    void Start()
    {
        GameObject jogadorObj = GameObject.FindGameObjectWithTag("Player");

        if (jogadorObj != null)
        {
           jogador = jogadorObj.transform;
        }

        Destroy(gameObject, 5f); // Destroi o projétil após 5 segundos
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
