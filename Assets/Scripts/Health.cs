using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float PlayerHealth;
    public float PlayerHealthMax;
    public Image HealthBar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void KurangiNyawa()
    {
        PlayerHealth--;
        HealthBar.fillAmount = PlayerHealth / 10f;
    }
}
