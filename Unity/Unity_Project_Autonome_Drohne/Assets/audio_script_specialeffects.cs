using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_script_specialeffects : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] audioClips;
    public float[] clipDurations;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayAudioClips());
    }

    IEnumerator PlayAudioClips()
    {
        for (int i = 0; i < audioClips.Length; i++)
        {
            audioSource.clip = audioClips[i];
            audioSource.Play();
            yield return new WaitForSeconds(clipDurations[i]);
            audioSource.Stop();
        }
    }
}
