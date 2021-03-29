using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(LuminousSceneManager))]
public class LuminousSceneManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        LuminousSceneManager myScript = (LuminousSceneManager)target;
        if (GUILayout.Button("Export"))
        {

        }
    }
}

