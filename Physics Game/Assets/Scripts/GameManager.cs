using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Vector2 xBounds;
    public Vector2 yBounds;

    public GameObject myEnemy;

    //timers
    public float enemyTimer = 0f;
    public float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        enemyTimer += Time.deltaTime;

        Vector3 targetPos = new Vector3(Random.Range(xBounds.x, xBounds.y), Random.Range(yBounds.x, yBounds.y), 0);
        if (enemyTimer > spawnInterval)
        {
            enemyTimer = 0f;
            Instantiate(myEnemy, targetPos, Quaternion.identity);

        }
    }
}
