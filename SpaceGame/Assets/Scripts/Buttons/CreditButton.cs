using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private EnemyScript _enemy;
    [SerializeField] private BossScript _boss;
    [SerializeField] private GameController _gc;
    private int _price;
    void Start()
    {
        _price = 150;
        _button.onClick.AddListener(() => Click());
    }

    void Click()
    {
        if (_gc.score > _price)
        {
            _gc.score -= _price;
            _price *= 2;
            _enemy._energy *= 2;
            _boss._BSenergy *= 2;
        }
        else
            _gc.Red();

    }
}
