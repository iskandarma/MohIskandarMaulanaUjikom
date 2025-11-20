using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health health;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 3f);
        GameObject _gameObject = GameObject.FindGameObjectWithTag("Health");
        health = _gameObject.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Peluru"))
        {
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Lantai"))
        {
            health.KurangiNyawa();
            Destroy(gameObject);
        }
    }
}
