using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_material : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rendiboy = GetComponent<Renderer>();
        thismaterial = rendiboy.material;
        StartCoroutine(changeImage());
    }

    IEnumerator changeImage()
    {
        for (int i = 0; i < image.Length; i++)
        {
           
            thismaterial.SetTexture("_MainTex", image[i]);
            yield return new WaitForSeconds(duration[i]);
        }
    }

    public Texture[] image;
    private Renderer rendiboy;
    private Material thismaterial;
    public float[] duration;
}
