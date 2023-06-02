using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreditButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private EnemyScript _enemy;
    [SerializeField] private BossScript _boss;
    [SerializeField] private GameController _gc;
    [SerializeField] private TextMeshProUGUI _text;
    private int _price;
    void Start()
    {
        _price = 150;
        _text.text = _price.ToString();
        _button.onClick.AddListener(() => Click());
    }

    void Click()
    {
        if (_gc.score >= _price)
        {
            _enemy._energy *= 2;
            _gc.score -= _price;
            _price *= 2;
            _text.text = _price.ToString();
            _gc.IncreaseScore(0);
        }
        else
            _gc.Red();

    }
}
