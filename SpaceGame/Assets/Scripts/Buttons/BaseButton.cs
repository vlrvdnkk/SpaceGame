using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private HpBar _hp;
    [SerializeField] private GameController _gc;
    private int _price;
    void Start()
    {
        _price = 100;
        _button.onClick.AddListener(() => Click());
    }

    void Click()
    {
        if (_gc.score > _price)
        {
            _gc.score -= _price;
            _price *= 2;
            _hp.Start();
        }
        else
            _gc.Red();
    }
}
