using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortData
{
    public string TypeKey;
    public string InstanceKey;
    public string Title;
}

public class PortEditor : MonoBehaviour
{
    PortData data;

    public void SetData(PortData data)
    {
        this.data = data;
        gameObject.name = data.InstanceKey;
    }
}
