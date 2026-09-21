using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena : MonoBehaviour
{
    public void TrocaCena (string Jogo )
    {
               SceneManager.LoadScene(Jogo);
    }

    public void TrocaControle (string Controles)
    {
        SceneManager.LoadScene(Controles);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
