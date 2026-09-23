using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class ContadorVitoria : MonoBehaviour
{
    public static ContadorVitoria Instance;
    public int pontos = 0;
    public int pontosVitoria = 25;
    public TextMeshProUGUI textoPlacar;
    void Start()
    {
        AtualizarTextoPlacar();

    }

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void AdicionarPontos()
    {
        pontos++;
        AtualizarTextoPlacar();
        if (pontos >= pontosVitoria)
        {
            SceneManager.LoadScene("Vitoria");
        }

    }

    public void AtualizarTextoPlacar()
    {

        if (textoPlacar != null)
        {
            textoPlacar.text = "Inimigo " + pontos + "/" + pontosVitoria;
        }
    }

    
}
