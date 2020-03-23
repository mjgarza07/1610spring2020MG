﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class VectorThreeData : ScriptableObject
{
    public Vector3 value;

    public void ChangePosition(Transform transformObj)
    {
        transformObj.position = value;
    }

    public void ChangeValueFromTransform(Transform transformObj)
    {
        value = transformObj.position;
    }

    public void ChangeVectorThreeData(VectorThreeData vectorThreeDataObj)
    {
        vectorThreeDataObj.value = value;
    }
}
