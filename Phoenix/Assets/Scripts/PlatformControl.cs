using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour
{
    public GameObject platform;
    public float yMin, yMax, xMin, xMax;

    void Start()
    {
        
    }

    void platformSpawn()
    {
        float y = Random.Range(yMin, yMax);
        float x = Random.Range(xMin, xMax);
        Vector3 pos = new Vector3(x, y, 0);
        Instantiate(platform, pos, transform.rotation);
    }
}
