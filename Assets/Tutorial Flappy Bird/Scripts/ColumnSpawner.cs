using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{

    public GameObject column;
    public float delay = 3f;
    public float randomDelay = 2f;
    public float spawnX = 4;
    public float spawnYmin = 1;
    public float spawnYmax = 3.5f;


    IEnumerator Start()
    {
        while(true)
        {
            Vector3 pos;
            pos.z = 0;
            pos.x = spawnX;
            pos.y = Random.Range(spawnYmin, spawnYmax);
            Instantiate(column, pos, column.transform.rotation);

            yield return new WaitForSeconds(delay
            + Random.Range(-randomDelay, randomDelay));
        }
    }

    
}
