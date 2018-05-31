using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject Enemy;
    private float span = 3.0f;
    private float delta = 0;
    private  float enemyCount = 0f;
    public float enemyNumber = 5f;

    void Start()
    {
        //_enemies = new List<GameObject>();
    }

	// Update is called once per frame
	void Update ()
	{
	    delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;

            int randLocation1 = Random.Range(-22, -36);
            int randLocation2 = Random.Range(54, 80);

            if (enemyCount < enemyNumber)
            {
                GameObject enemy = Instantiate(Enemy);
                //enemy.tag = "1";
                enemy.transform.position = new Vector3(randLocation2, 5, randLocation1);
                enemyCount++;

                //_enemies.Add(enemy);
            }

            return;
        }
	}

    //private List<GameObject> _enemies;

    //public void DestroyEnemy(string tag)
    //{
    //    GameObject clone = _enemies.Find(x => x.CompareTag(tag));
    //    if (clone != null)
    //        Destroy(clone);
    //}
}

