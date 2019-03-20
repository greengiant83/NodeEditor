using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NodeDefinition
{
    //TODO: define NodeDefinition
}

public class NodeData
{
    public string TypeKey;
    public string InstanceKey;
    public string Title;
    public List<PortData> PortsIn = new List<PortData>();
    public List<PortData> PortsOut = new List<PortData>();
}

public class NodeEditor : MonoBehaviour
{
    public GameObject PortEditorPrefab;

    NodeData data;
    Transform PortsInGO;
    Transform PortsOutGO;

    private void Awake()
    {
        PortsInGO = transform.Find("Ports In");
        PortsOutGO = transform.Find("Ports Out");
    }

    public void SetData(NodeData data)
    {
        this.data = data;

        gameObject.name = data.InstanceKey;

        foreach(var port in data.PortsIn)
        {
            var portEditorObject = GameObject.Instantiate(PortEditorPrefab);
            var portEditor = portEditorObject.GetComponent<PortEditor>();
            Debug.Log("Setting in port parent: " + PortsInGO);
            portEditorObject.transform.SetParent(PortsInGO);
            portEditor.SetData(port);
        }

        foreach (var port in data.PortsOut)
        {
            var portEditorObject = GameObject.Instantiate(PortEditorPrefab);
            var portEditor = portEditorObject.GetComponent<PortEditor>();
            portEditorObject.transform.SetParent(PortsOutGO);
            portEditor.SetData(port);
        }
    }
}
