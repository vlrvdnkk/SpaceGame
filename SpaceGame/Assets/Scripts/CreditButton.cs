using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private EnemyScript _enemy;
    [SerializeField] private BossScript _boss;
    void Start()
    {
        _button.onClick.AddListener(() => Click());
    }

    void Click()
    {
        _enemy._energy *= 2;
        _boss._BSenergy *= 2;
    }
}
