using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraController : MonoBehaviour
{
    private Vector3 offset;
    public Camera camera;
    public Rigidbody2D player;

    private void Start()
    {
        offset = camera.transform.position - player.transform.position;
    }
    private void LateUpdate()
    {
        camera.transform.position = player.transform.position + offset;
    }


}
