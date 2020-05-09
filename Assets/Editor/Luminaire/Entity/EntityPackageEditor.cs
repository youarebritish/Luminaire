using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;
using SQEX.Ebony.Framework.Entity;

namespace Luminaire.Entity
{
    [CustomEditor(typeof(EntityPackageAsset))]
    public class EntityPackageEditor : Editor
    {
        private const string InspectedEntityLabelName = "InspectedEntityLabel";
        private const string StylesheetPath = "Assets/Editor/Luminaire/Entity/EntityPackageEditor.uss";
        private const string VisualTreePath = "Assets/Editor/Luminaire/Entity/EntityPackageEditor.uxml";
        [SerializeField]
        private VisualElement rootElement;

        public override VisualElement CreateInspectorGUI()
        {
            this.rootElement = new VisualElement();
            ImportUxmlAndStylesheet(this.rootElement);

            var asset = (EntityPackageAsset)target;
            var package = asset.Package;

            var items = PopulateEntityList(package);
            InitializeEntityList(rootElement, items);

            var defaultInspector = new IMGUIContainer(DrawEntityInspector);
            rootElement.Add(defaultInspector);

            return rootElement;
        }

        private static void ImportUxmlAndStylesheet(VisualElement rootElement)
        {
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VisualTreePath);
            visualTree.CloneTree(rootElement);

            var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>(StylesheetPath);
            rootElement.styleSheets.Add(styleSheet);
        }

        private static void InitializeEntityList(VisualElement rootElement, List<string> items)
        {
            var listView = rootElement.Q<ListView>();

            VisualElement makeItem() => new Label();
            void bindItem(VisualElement e, int i) => (e as Label).text = items[i];

            listView.makeItem = makeItem;
            listView.bindItem = bindItem;
            listView.itemsSource = items;
            listView.selectionType = SelectionType.Single;
        }

        private static List<string> PopulateEntityList(EntityPackage package)
        {
            var items = new List<string>();
            for (var i = 0; i < package.loadedObjects_.Count; i++)
            {
                items.Add(package.loadedObjectNames_[i]);
            }

            return items;
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

            var selectedObjLabel = this.rootElement.Q<Label>(InspectedEntityLabelName);
            selectedObjLabel.text = $"{package.loadedObjectNames_[listView.selectedIndex]} ({package.loadedObjects_[listView.selectedIndex].GetType().FullName})";

            var packageProperty = serializedObject.FindProperty("Package");
            var listProperty = packageProperty.FindPropertyRelative("loadedObjects_");
            var listItemProperty = listProperty.GetArrayElementAtIndex(listView.selectedIndex);
            EditorGUILayout.PropertyField(listItemProperty, includeChildren: true);
        }
    }
}