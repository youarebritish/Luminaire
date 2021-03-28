using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Luminaire
{
    public class LuminaireSettings : ScriptableObject
    {
        public const string SettingsPath = "Assets/Editor/LuminaireSettings.asset";

        [SerializeField]
        public string GamePath = string.Empty;

        public static SerializedObject SerializedInstance => new SerializedObject(Instance);

        public static LuminaireSettings Instance
        {
            get
            {
                var settings = AssetDatabase.LoadAssetAtPath<LuminaireSettings>(SettingsPath);
                if (settings == null)
                {
                    settings = ScriptableObject.CreateInstance<LuminaireSettings>();
                    AssetDatabase.CreateAsset(settings, SettingsPath);
                    AssetDatabase.SaveAssets();
                }

                return settings;
            }
        }
    }

    public class LuminaireSettingsProvider : SettingsProvider
    {
        private SerializedObject customSettings;

        public LuminaireSettingsProvider(string path, SettingsScope scope = SettingsScope.Project)
            : base(path, scope) { }

        public static bool IsSettingsAvailable => File.Exists(LuminaireSettings.SettingsPath);

        [SettingsProvider]
        public static SettingsProvider CreateMyCustomSettingsProvider()
        {
            return new LuminaireSettingsProvider("Luminaire/", SettingsScope.Project)
            {
                label = "FFXV",
                keywords = GetSearchKeywordsFromGUIContentProperties<Styles>()
            };
        }

        public override void OnActivate(string searchContext, VisualElement rootElement) => customSettings = LuminaireSettings.SerializedInstance;

        // TODO: Convert to UIElements
        public override void OnGUI(string searchContext)
        {
            var pathProperty = customSettings.FindProperty("GamePath");

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PropertyField(pathProperty, Styles.gamePath);
            if (GUILayout.Button("Select"))
            {
                var path = EditorUtility.OpenFilePanel("Select game executable", string.Empty, "exe");
                if (!string.IsNullOrEmpty(path))
                {
                    pathProperty.stringValue = path;
                    customSettings.ApplyModifiedProperties();
                }
            }

            EditorGUILayout.EndHorizontal();
        }

        class Styles
        {
            public static GUIContent gamePath = new GUIContent("Game Path");
        }
    }
}