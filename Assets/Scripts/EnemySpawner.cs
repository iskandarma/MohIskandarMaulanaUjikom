using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawnEnemyType1;
    public GameObject spawnEnemyType2;
    public GameObject spawnEnemyType3;
    public bool sedangSpawn = true;

    public float intervalSpawn = 2f;
    public int typeEnemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(MunculkanEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculkanEnemy()
    {
        while (sedangSpawn == true)
        {
            typeEnemy = Random.Range(1,4);
            if (typeEnemy == 1)
            {
                Instantiate(spawnEnemyType1, new Vector3(Random.Range(-5,5), 5 ,0), Quaternion.identity);
            } else if(typeEnemy==2)
            {
                Instantiate(spawnEnemyType2, new Vector3(Random.Range(-5,5), 5 ,0), Quaternion.identity);
            } else if (typeEnemy == 3)
            {
                Instantiate(spawnEnemyType3, new Vector3(Random.Range(-5,5), 5 ,0), Quaternion.identity);
            }
            yield return new WaitForSeconds(intervalSpawn);
        }
    }
}
