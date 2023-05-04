using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_script : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoClip[] VideoCLips;
    public float[] clipDurations;
    private VideoPlayer V_Player;
    public float[] clipSpeeds= { 1, 1, 1 };

    void Start()
    {
        V_Player= GetComponent<VideoPlayer>();
        
        StartCoroutine(PlayVideoClips());
    }

    IEnumerator PlayVideoClips()
    {
        for (int i = 0; i < VideoCLips.Length; i++)
        {
            V_Player.clip = VideoCLips[i];
           
            V_Player.Play();
            V_Player.playbackSpeed = clipSpeeds[i];
            yield return new WaitForSeconds(clipDurations[i]);
        }
    }
   
    
}
