using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData
{
    public string InstanceKey;
    public string Title;
    public List<NodeData> Nodes = new List<NodeData>();
    public List<ConnectionData> Connections = new List<ConnectionData>();
}

public class MapEditor : MonoBehaviour
{
    public GameObject NodeEditorPrefab;
    public GameObject ConnectionEditorPrefab;

    Transform NodesGO;
    Transform ConnectionsGO;
    MapData data;

    void Awake()
    {
        NodesGO = transform.Find("Nodes");
        ConnectionsGO = transform.Find("Connections");
    }

    public void SetData(MapData data)
    {
        this.data = data;
        gameObject.name = data.Title;

        foreach(var node in data.Nodes)
        {
            var nodeEditorObject = GameObject.Instantiate(NodeEditorPrefab);
            var nodeEditor = nodeEditorObject.GetComponent<NodeEditor>();
            nodeEditorObject.transform.SetParent(NodesGO);
            nodeEditor.SetData(node);
        }

        foreach(var connection in data.Connections)
        {
            var connectionEditorObject = GameObject.Instantiate(ConnectionEditorPrefab);
            var connectionEditor = connectionEditorObject.GetComponent<ConnectionEditor>();
            connectionEditorObject.transform.SetParent(ConnectionsGO);
            connectionEditor.SetData(connection);
        }
    }
}
