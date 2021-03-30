using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace SQEX.Luminous.Core.Object
{
    [CustomEditor(typeof(LuminousSceneManager))]
    public class LuminousSceneManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            LuminousSceneManager myScript = (LuminousSceneManager)target;

            if (GUILayout.Button("Export"))
            {
                //myScript.ManagerObject.TestDebug();
                myScript.TestDbjectType();
            }
        }
    }
}

