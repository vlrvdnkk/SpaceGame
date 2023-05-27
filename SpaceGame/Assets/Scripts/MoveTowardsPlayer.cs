using UnityEngine;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour
{
    private Transform player;
    public float speed = 1.5f;

    void Start()
    {
        player = GameObject.Find("playerShip").transform;
    }

    void Update()
    {
        Vector3 delta = player.position - transform.position;
        delta.Normalize();
        float moveSpeed = speed * Time.deltaTime;
        transform.position = transform.position + (delta * moveSpeed);
    }
}