using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    private float _angle;
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        Vector3 worldPos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(worldPos);
        float dx = this.transform.position.x - worldPos.x;
        float dy = this.transform.position.y - worldPos.y;
        if (transform.position.y < worldPos.y)
        {
            _angle = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
            _angle = _angle < 0 ? _angle : -_angle;
            Quaternion rot = Quaternion.Euler(new Vector3(0, 0, _angle + 90));
            this.transform.rotation = rot;
        }
    }
}