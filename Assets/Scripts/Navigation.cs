using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public AudioSource _MainMenu;
    public AudioSource _GamePlay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Menu()
    {
        _MainMenu.Play();
        SceneManager.LoadScene("MainMenu");
    }

    public void Mulai()
    {
        _MainMenu.Stop();
        _GamePlay.Play();
        SceneManager.LoadScene("ScenePlay");
    }

    public void Kredit()
    {
        SceneManager.LoadScene("SceneCredit");
    }

    public void Keluar()
    {
        Application.Quit();
    }
}
