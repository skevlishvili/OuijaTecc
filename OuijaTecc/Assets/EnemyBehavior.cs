using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0,0,0), Speed);
    }

    void OnTriggerEnter2D() {
        Debug.Log("destroyed");
        Object.Destroy(gameObject, 0.0f);
    }   
}
