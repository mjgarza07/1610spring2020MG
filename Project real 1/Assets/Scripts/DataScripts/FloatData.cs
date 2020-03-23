﻿
using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value = 1f;

    public void OnChangeValue(float number)
    {
        value += number;
    }
}
