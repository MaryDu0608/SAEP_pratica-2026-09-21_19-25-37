using UnityEngine;
using UnityEngine.UI;


public class HudVida : MonoBehaviour
{
    public Image[] coracoes;
    public Sprite coracaoCheio;
    public Sprite coracaoVazio;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void AtualizarHud(int vidaAtual)
    {

        Debug.Log("Atualizou");
        for (int i = 0; i < coracoes.Length; i++)
        {

            coracoes[i].enabled = true;
            if(i == vidaAtual)
            {

                Debug.Log("vida1");
                coracoes[i].enabled = coracaoCheio;
            }
            else
            {
                Debug.Log("vida2");
                coracoes[i].enabled = coracaoVazio;
            }




        }
    }
}
