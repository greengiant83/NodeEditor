using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionData
{
    public string FromPortKey;
    public string ToPortKey;
}

public class ConnectionEditor : MonoBehaviour
{
    ConnectionData data;

    public void SetData(ConnectionData data)
    {
        this.data = data;

        gameObject.name = data.FromPortKey + " to " + data.ToPortKey;
    }
}
