using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint : MonoBehaviour
{
    public Vector3 _axis;
    public Vector3 _startOffset;

    public void Awake() => _startOffset = transform.localPosition;
}
