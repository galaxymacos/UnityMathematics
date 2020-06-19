using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coo2D
{
    public float x;
    public float y;

    public Coo2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Coo3D : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
}

public class Coo4D : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float w;
}