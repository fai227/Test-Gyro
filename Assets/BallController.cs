using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private static float maxTime = 5f;
    private float startTime = 0f;
    [SerializeField] private float speed = 1.0f;
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        transform.localPosition = transform.localPosition + (Vector3)(Vector2.up * speed * Time.deltaTime);

        if (Time.time - startTime > maxTime)
        {
            Destroy(gameObject);
        }
    }
}
