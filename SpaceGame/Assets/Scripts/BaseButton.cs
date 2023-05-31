using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private HpBar _hp;
    void Start()
    {
        _button.onClick.AddListener(() => Click());
    }

    void Click()
    {
        _hp.Start();
    }
}
