using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _left;
    [SerializeField] private GameObject _right;
    [SerializeField] private LaserScript _laser;
    [SerializeField] private GameController _gc;
    private int _price;
    private int _counter = 1;
    void Start()
    {
        _price = 200;
        _button.onClick.AddListener(() => Click());
    }

    void Click()
    {
        if (_gc.score > _price)
        {
            _gc.score -= _price;
            _price *= 2;
            if (_counter == 1)
            {
                _left.SetActive(true);
                _counter++;
            }
            else if (_counter == 10)
            {
                _right.SetActive(true);
                _counter++;
            }
            else if (_counter > 10 & _counter % 2 == 0)
            {
                _laser.damageB *= 2;
                _counter++;
            }
            else if (_counter > 10)
            {
                _laser.damageA *= 2;
                _counter++;
            }
            else
            {
                _laser.damageA *= 2;
                _counter++;
            }
        }
        else
            _gc.Red();
    }
}
