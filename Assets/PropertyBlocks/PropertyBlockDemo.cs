using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyBlockDemo : MonoBehaviour
{
    public Renderer renderer;
    public string propertyName;
    public Color property;
    public bool usePropertyBlock;
    public bool randomColors;

    private MaterialPropertyBlock _propertyBlock;

    void Start()
    {
        _propertyBlock = new MaterialPropertyBlock();
        if (randomColors)
            property = Random.ColorHSV();
    }

    void Update()
    {
        if (usePropertyBlock)
        {
            // get previous values
            renderer.GetPropertyBlock(_propertyBlock);
            // modify them
            _propertyBlock.SetColor(propertyName, property);
            // apply them
            renderer.SetPropertyBlock(_propertyBlock);
        }
        else
        {
            renderer.material.SetColor(propertyName, property);
        }
    }
}