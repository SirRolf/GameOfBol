using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (MapGenerate))]
public class MapEditor : Editor {

    public override void OnInspectorGUI ()
    {
        base.OnInspectorGUI();

        MapGenerate map = target as MapGenerate;

        map.GenerateMap();
    }

}
