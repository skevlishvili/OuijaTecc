using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    private float initialEnemySpeed = 0.01f;
    private int speedBuildUp = 0;

    private int distance = 12;
    // Start is called before the first frame update
    void Start()
    {   
        StartCoroutine("WaitAndSpawn");
    }

    // every 2 seconds perform the print()
    private IEnumerator WaitAndSpawn()
    {
        while (true)
        {
            var degrees = Random.Range(0, 72)*5;
            var x = distance*Mathf.Cos((degrees * Mathf.PI)/180);
            var y = distance*Mathf.Sin((degrees * Mathf.PI)/180);
            var prefab  = Instantiate(enemy, new Vector3(x, y, 0), Quaternion.Euler(0, 0, degrees-90)) as GameObject;
            var EnemyBehavior = (EnemyBehavior)prefab.GetComponent("EnemyBehavior");
            int addedSpeed = speedBuildUp/100;
            EnemyBehavior.Speed = initialEnemySpeed + (float)addedSpeed/100;
            speedBuildUp++;
            yield return new WaitForSeconds(1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
