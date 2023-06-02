using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private LaserScript _laser;
    [SerializeField] private GameController _gc;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private AudioClip _hitSound;

    private int _price;
    void Start()
    {
        _price = 200;
        _text.text = _price.ToString();
        _button.onClick.AddListener(() => Click());
    }

    void Click()
    {
        if (_gc.score >= _price)
        {
            _gc.score -= _price;
            _price *= 2;
            GetComponent<AudioSource>().PlayOneShot(_hitSound);
            _laser.damage *= 2;
            _text.text = _price.ToString();
            _gc.IncreaseScore(0);
        }
        else
            _gc.Red();
    }
}
