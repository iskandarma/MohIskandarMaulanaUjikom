using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
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
        SceneManager.LoadScene("MainMenu");
    }

    public void Mulai()
    {
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
