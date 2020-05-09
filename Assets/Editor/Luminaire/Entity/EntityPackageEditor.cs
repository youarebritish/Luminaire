using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using System.Collections.Generic;
using System;

namespace Luminaire.Entity
{
    [CustomEditor(typeof(EntityPackageAsset))]

    public class EntityPackageEditor : Editor
    {
        /*public void OnEnable()
        {
            var rootElement = new VisualElement();

            // Import UXML
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Luminaire/Entity/EntityPackageEditor.uxml");
            visualTree.CloneTree(rootElement);

            // A stylesheet can be added to a VisualElement.
            // The style will be applied to the VisualElement and all of its children.
            var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/Luminaire/Entity/EntityPackageEditor.uss");
            rootElement.styleSheets.Add(styleSheet);
        }*/

        public override void OnInspectorGUI()
        {
            EditorGUILayout.LabelField("Custom inspector written in: IMGUI");

            serializedObject.Update();

            EditorGUILayout.PropertyField(serializedObject.FindProperty("Intvalue"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("stringValue"));

            serializedObject.ApplyModifiedProperties();
        }

        public override VisualElement CreateInspectorGUI()
        {
            var rootElement = new VisualElement();

            // Import UXML
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Luminaire/Entity/EntityPackageEditor.uxml");
            visualTree.CloneTree(rootElement);

            // A stylesheet can be added to a VisualElement.
            // The style will be applied to the VisualElement and all of its children.
            var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/Luminaire/Entity/EntityPackageEditor.uss");
            rootElement.styleSheets.Add(styleSheet);

            var asset = (EntityPackageAsset)target;
            var package = asset.Package;

            // Create some list of data, here simply numbers in interval [1, 1000]
            const int itemCount = 1000;
            var items = new List<string>();
            /*for (int i = 1; i <= itemCount; i++)
                items.Add(i.ToString());*/

            for(var i = 0; i < package.loadedObjects_.Count; i++)
            {
                var obj = package.loadedObjects_[i];
                items.Add(package.loadedObjectNames_[i]);
            }

            // The "makeItem" function will be called as needed
            // when the ListView needs more items to render
            Func<VisualElement> makeItem = () => new Label();

            // As the user scrolls through the list, the ListView object
            // will recycle elements created by the "makeItem"
            // and invoke the "bindItem" callback to associate
            // the element with the matching data item (specified as an index in the list)
            Action<VisualElement, int> bindItem = (e, i) => (e as Label).text = items[i];

            var listView = rootElement.Q<ListView>();
            listView.makeItem = makeItem;
            listView.bindItem = bindItem;
            listView.itemsSource = items;
            listView.selectionType = SelectionType.Multiple;

            // Callback invoked when the user double clicks an item
            listView.onItemChosen += obj => Debug.Log(obj);

            // Callback invoked when the user changes the selection inside the ListView
            listView.onSelectionChanged += objects => Debug.Log(objects);

            return rootElement;
        }
    }
}