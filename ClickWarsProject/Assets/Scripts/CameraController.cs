using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
    void Start() 
    {
        float orthoSize = rend.bounds.size.x * 13 * Screen.height / Screen.width * 0.5f;
        Debug.Log(rend.bounds.size.x);
        Camera.main.orthographicSize = orthoSize;
    }


}
