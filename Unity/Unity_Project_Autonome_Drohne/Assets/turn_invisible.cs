using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_invisible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > 55f)
        {
            gameObject.SetActive(false);
        }
    }
    
}
