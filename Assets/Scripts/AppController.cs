using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour
{
    public static AppController Instance;

    public MapEditor MapEditor;
    public MapStore MapStore;
    
    void Start()
    {
        Instance = this;

        var mapData = MapStore.GetMockData();
        MapEditor.SetData(mapData);
    }
}
