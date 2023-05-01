using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thunderbolt : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        thunder_button = false;
    }



    // Update is called once per frame
    void Update()
    {
        if (thunder_button)
        {
            audio.Play();
            thunder.SetActive(false);
        }
        else
        {
            audio.Stop();
            thunder.SetActive(true);
        }
    }


    private AudioSource audio;
    public bool thunder_button;
    public GameObject thunder;
}
