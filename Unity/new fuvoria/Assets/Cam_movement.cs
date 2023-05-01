using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_movement : MonoBehaviour
{
    private Camera cam;

    private float x;
    private Vector3 rotation;
    private float y;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
        rotation = new Vector3(-y, x, 0);
        transform.eulerAngles = transform.eulerAngles + rotation;

    }
    public static bool IsObjectVisible(this UnityEngine.Camera @this, Renderer renderer)
    {
        return GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(@this), renderer.bounds);
    }
}
