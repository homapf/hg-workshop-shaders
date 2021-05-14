using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morph : MonoBehaviour
{
    public SkinnedMeshRenderer firstMesh;
    public SkinnedMeshRenderer otherMesh;
    [Range(0, 10)] public float speed;

    private static readonly int ShaderAnimationHeight = Shader.PropertyToID("Vector1_5fbe8ec13dc847858012f3e541b07180");

    private void Update()
    {
        var anim = Mathf.PingPong(Time.time * speed, 6) - 3;
        firstMesh.material.SetFloat(ShaderAnimationHeight, anim);
        otherMesh.material.SetFloat(ShaderAnimationHeight, anim);
    }
}