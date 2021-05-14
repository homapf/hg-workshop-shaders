using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    private Camera _camera;
    public CustomRenderTexture paintRenderTexture;

    private void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        RaycastHit hit;
        var dir = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(dir.origin, dir.direction, out hit, Mathf.Infinity))
        {
            Debug.DrawRay(dir.origin, dir.direction * hit.distance,
                Color.yellow);
            paintRenderTexture.material.SetVector("Vector2_5f08f96aa42c42eca01ed6751d725663",- hit.textureCoord + new Vector2(0.5f,0.5f));
        }
        else
        {
            Debug.DrawRay(dir.origin, dir.direction * 1000,
                Color.white);
        }
    }
}