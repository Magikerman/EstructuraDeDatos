using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class recordObject
{
    public Vector3 position { get; set; }
    public Quaternion rotation { get; set; }

    public recordObject(Vector3 Position, Quaternion Rotation)
    {
        position = Position;
        rotation = Rotation;
    }
}
