using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour
{

    public GameObject platform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    List<float> possibleMultipliers = new List<float>(new float[] { -4, -3, -2, -1, 1, 2, 3, 4, 5 });

    void Start()
    {
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
    }

    void Update()
    {

        if (transform.position.x < generationPoint.position.x) 
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

           transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween,
                                            1 * possibleMultipliers[Random.Range(0, possibleMultipliers.Count)],
                                            0);

            Instantiate(platform, transform.position, transform.rotation);

        }
    }
}
