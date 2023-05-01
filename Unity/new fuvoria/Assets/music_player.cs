using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_player : MonoBehaviour
{
    Camera cam;
    AudioSource audio;
    Vector3 viewPos;


    void Start()
    {
        cam = Camera.main;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        viewPos = cam.WorldToViewportPoint(transform.position);
        if (viewPos.x > 0 && viewPos.x < 1 && viewPos.y > 0 && viewPos.y < 1)
        {
            if (!audio.isPlaying)
                audio.Play(0);
        }
        else
        {
            audio.Stop();
        }

    }
}
