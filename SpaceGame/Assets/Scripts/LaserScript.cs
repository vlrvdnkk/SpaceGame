using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LaserScript : MonoBehaviour
{
    public float lifetime = 2.0f;
    public float speed = 5.0f;
    public int damage = 1;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}