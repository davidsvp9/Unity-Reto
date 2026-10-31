using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneFlow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void LoadGame()
    {
        SceneManager.LoadScene("Partida");
    }
}