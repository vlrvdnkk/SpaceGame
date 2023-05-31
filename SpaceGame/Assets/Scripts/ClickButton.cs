using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private LaserScript _laser;
    void Start()
    {
        _button.onClick.AddListener(() => Click());
    }

    void Click()
    {
        _laser.damage *= 2;
    }
}
