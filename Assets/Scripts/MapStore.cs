using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapStore : MonoBehaviour
{
    public MapData GetMockData()
    {
        return new MapData()
        {
            Title = "My Map",
            InstanceKey = "my_map",
            Nodes = new List<NodeData>()
            {
                new NodeData()
                {
                    TypeKey = "Stuff.Sphere",
                    Title = "My Sphere",
                    InstanceKey = "my_sphere",
                    PortsOut = new List<PortData>()
                    {
                        new PortData()
                        {
                            TypeKey = "Geo",
                            Title = "Geometry",
                            InstanceKey = "geometry",
                        }
                    }
                },

                new NodeData()
                {
                    TypeKey = "Stuff.ScatterPoints",
                    Title = "Scatter Points",
                    InstanceKey = "scatter_points",
                    PortsIn = new List<PortData>()
                    {
                        new PortData()
                        {
                            TypeKey = "Geo",
                            Title = "Geometry",
                            InstanceKey = "geometry"
                        }
                    },

                    PortsOut = new List<PortData>()
                    {
                        new PortData()
                        {
                            TypeKey = "Geo",
                            Title = "Output Points",
                            InstanceKey = "output_points"
                        }
                    }
                },

                new NodeData()
                {
                    TypeKey = "Stuff.VoronoiFracture",
                    Title = "Voronoi Fracture",
                    InstanceKey = "voronoi_fracture",
                    PortsIn = new List<PortData>()
                    {
                        new PortData()
                        {
                            TypeKey = "Geo",
                            Title = "Geometry to Fracture",
                            InstanceKey = "geometry"
                        },

                        new PortData()
                        {
                            TypeKey = "Geo",
                            Title = "Points for Voronoi Cells",
                            InstanceKey = "points"
                        }
                    },

                    PortsOut = new List<PortData>()
                    {
                        new PortData()
                        {
                            TypeKey = "Geo",
                            Title = "Output",
                            InstanceKey = "output"
                        }
                    }
                }
            },

            Connections = new List<ConnectionData>()
            {
                new ConnectionData()
                {
                    FromPortKey = "my_sphere.geometry",
                    ToPortKey = "scatter_points.geometry"
                },

                new ConnectionData()
                {
                    FromPortKey = "scatter_points.output_points",
                    ToPortKey = "voronoi_fracture.points"
                },

                new ConnectionData()
                {
                    FromPortKey = "my_sphere.geometry",
                    ToPortKey = "voronoi_fracture.geometry"
                }
            }
        };
    }
}
