using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeaudio : MonoBehaviour
{
    public float groundlevel = -3.0f;
    public GameObject cubeprefab;
    private AudioSource sound;
    bool isplay = false;

    void Start()
    {
        cubeprefab = GameObject.Find("cubeprefab");
        sound = GetComponent<AudioSource>();

    }
    void Update()
    {
        if (!isplay && gameObject.transform.position.y <=groundlevel + 2)
        { sound.PlayOneShot(sound.clip); isplay = true;
        }
    }
}

