using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] KeyCode spawnKey;
    
    void Update()
    {
        if(Input.GetKey(spawnKey))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
