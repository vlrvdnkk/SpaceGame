using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public int _curHealth = 0;
    public int _maxHealth = 100;   
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Slider _bossBar;
    [SerializeField] private SpriteRenderer _image;
    [SerializeField] private Sprite _crashedObservatory;
    [SerializeField] private CinemachineImpulseSource _cinemachine;
    [SerializeField] private Animator anim;
    [SerializeField] private BossScript boss;
    [SerializeField] private LaserScript laser;
    [SerializeField] private GameObject _panel;

    public void Start()
    {
        _bossBar.interactable = false;
        _healthBar.interactable = false;
        _curHealth = _maxHealth;
        _healthBar.value = _curHealth;
    }

    public void DamagePlayer(int damage)
    {
        _curHealth -= damage;
        _healthBar.value = _curHealth;
        if (_curHealth <= 25)
        {
            _image.sprite = _crashedObservatory;
        }
        if (_curHealth <= 0)
        {
            _cinemachine.GenerateImpulse();
            anim.SetBool("obDeath", true);
            StartCoroutine(Timer());
        }
    }
    public void BossBar(int health)
    {
        _bossBar.value = health;
    }
    public void BossBarMax(int health)
    {
        _bossBar.maxValue = health;
        _bossBar.value = health;
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2);
        _panel.SetActive(true);
    }
}
