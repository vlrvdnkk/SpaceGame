using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private AudioSource _audioSrc;
    void Awake()
    {
        _audioSrc = GetComponent<AudioSource>();
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);

        }
        DontDestroyOnLoad(this.gameObject);
    }
}
