using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject panelVictoria;
    [SerializeField] private GameObject panelDerrota;

   
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip sonidoTesoro;
    [SerializeField] private AudioClip sonidoVictoria;
    [SerializeField] private AudioClip sonidoDerrota;



    private bool tieneTesoro;
    private bool partidaTerminada;

    private void Start()
    {
        Time.timeScale = 1f;
        panelVictoria.SetActive(false);
        panelDerrota.SetActive(false);
    }

    public void RecogerTesoro(GameObject tesoro)
    {
        if (partidaTerminada || tieneTesoro) return;
        tieneTesoro = true;
        tesoro.SetActive(false);
        audioSource.PlayOneShot(sonidoTesoro);
    }

  

    public void LlegarASalida()
    {
        if (partidaTerminada || !tieneTesoro) return;
        Terminar(panelVictoria, sonidoVictoria);
    }

    public void Perder()
    {
        if (partidaTerminada) return;
        Terminar(panelDerrota, sonidoDerrota);
    }

    private void Terminar(GameObject panel, AudioClip clip)
    {
        partidaTerminada = true;
        panel.SetActive(true);
        audioSource.PlayOneShot(clip);
        Time.timeScale = 0f;
    }

    
}
