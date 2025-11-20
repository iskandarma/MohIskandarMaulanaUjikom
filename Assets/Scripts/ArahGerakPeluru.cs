using UnityEngine;

public class ArahGerakPeluru : MonoBehaviour
{
    public float speed = 5f;
    public float PeluruLifeTime = 2f;
    public Score score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //menghapus peluru setelah 2 detik
        Destroy(gameObject, PeluruLifeTime);
        GameObject _gameObject = GameObject.FindGameObjectWithTag("Score");
        score = _gameObject.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            // Debug.Log("Nabrak Enemy");
            score.AddScore();
            score.UpdateScore();
            Destroy(gameObject);
        }
    }

}
