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
        [SerializeField]
        private VisualElement rootElement;

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
            this.rootElement = new VisualElement();

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
            var items = new List<string>();
            for (var i = 0; i < package.loadedObjects_.Count; i++)
            {
                var obj = package.loadedObjects_[i];
                items.Add(package.loadedObjectNames_[i]);
            }

            // The "makeItem" function will be called as needed
            // when the ListView needs more items to render
            VisualElement makeItem() => new Label();

            // As the user scrolls through the list, the ListView object
            // will recycle elements created by the "makeItem"
            // and invoke the "bindItem" callback to associate
            // the element with the matching data item (specified as an index in the list)
            void bindItem(VisualElement e, int i) => (e as Label).text = items[i];

            var listView = rootElement.Q<ListView>();
            listView.makeItem = makeItem;
            listView.bindItem = bindItem;
            listView.itemsSource = items;
            listView.selectionType = SelectionType.Single;

            // Callback invoked when the user double clicks an item
            listView.onItemChosen += obj => Debug.Log(obj);

            // Callback invoked when the user changes the selection inside the ListView
            listView.onSelectionChanged += objects => Debug.Log(objects);

            var defaultInspector = new IMGUIContainer(() => DrawEntityInspector());
            rootElement.Add(defaultInspector);

            return rootElement;
        }

        private void DrawEntityInspector()
        {
            var listView = this.rootElement.Q<ListView>();
            if (listView.selectedIndex == -1)
            {
                return;
            }

            var asset = (EntityPackageAsset)target;
            var package = asset.Package;
            var selectedObjLabel = this.rootElement.Q<Label>("InspectedEntityLabel");
            selectedObjLabel.text = package.loadedObjectNames_[listView.selectedIndex];

            var packageProperty = serializedObject.FindProperty("Package");
            var listProperty = packageProperty.FindPropertyRelative("loadedObjects_");
            var listItemProperty = listProperty.GetArrayElementAtIndex(listView.selectedIndex);
            EditorGUILayout.PropertyField(listItemProperty, includeChildren: true);
        }
    }
}