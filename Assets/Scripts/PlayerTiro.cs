using UnityEngine;

public class PlayerTiro : MonoBehaviour
{
    public float tempoEntreTiros = 0.2f;
    private float proximoTiro = 0f;
    public float velocidadeTiro = 10f;
    public float tempoDeVidaTiro = 2f;
    public GameObject tiroPrefab;
    public Transform pontoDeDisparo;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= proximoTiro)
        {
            proximoTiro = Time.time + tempoEntreTiros;
            Atirar();
        }
    }

    void Atirar()
    {
        
        GameObject bala = Instantiate(tiroPrefab, pontoDeDisparo.position, pontoDeDisparo.rotation);

       
        Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
           
            rb.linearVelocity = pontoDeDisparo.right * velocidadeTiro;
            Destroy(bala, tempoDeVidaTiro);
        }

        
    }
}
