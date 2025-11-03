using UnityEngine.SceneManagement;
using UnityEngine;

public class GerenciadorDeCenas : MonoBehaviour
{

    public void VoltarCenaAnteriorPorIndice()
    {
        int indiceCenaAtual = SceneManager.GetActiveScene().buildIndex;
        if (indiceCenaAtual > 0)
        {

            SceneManager.LoadScene(indiceCenaAtual - 1);
        }
        else
        {
            Debug.LogWarning("Não há cena anterior no Build Index!");
        }
    }
    public void VoltarParaMenuPrincipal()
    {
        SceneManager.LoadScene("NomeDaSuaCenaDeMenu");
    }
    public void CarregarCena(string nomeDaCena)
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
