using UnityEngine;

public class LaserScript : MonoBehaviour
{
    [SerializeField] private float lifetime = 2.0f;
    [SerializeField] private float speed = 5.0f;
    public int damage = 2;
    public int damageA = 2;
    public int damageB = 6;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}