using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_rotation_after_time : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad<55f)
        transform.Rotate(_rotation * Time.deltaTime);
    }
}