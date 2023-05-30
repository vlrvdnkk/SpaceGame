using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField] private int _curHealth = 0;
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private Slider _healthBar;
    [SerializeField] private SpriteRenderer _image;
    //[SerializeField] private GameObject _observatory;
    [SerializeField] private Sprite _crashedObservatory;

    void Start()
    {
        _curHealth = _maxHealth;
    }

    void Update()
    {

    }

    public void DamagePlayer(int damage)
    {
        _curHealth -= damage;
        _healthBar.value = _curHealth;
        if (_curHealth <= 25)
        {
            _image.sprite = _crashedObservatory;
        }
    }
}
