using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

class LuminaireSettings : ScriptableObject
{
    public const string SettingsPath = "Assets/Editor/LuminaireSettings.asset";

    [SerializeField]
    public string GamePath = string.Empty;

    internal static LuminaireSettings GetOrCreateSettings()
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

    internal static SerializedObject GetSerializedSettings()
    {
        return new SerializedObject(GetOrCreateSettings());
    }
}

class MyCustomSettingsProvider : SettingsProvider
{
    private SerializedObject customSettings;

    class Styles
    {
        public static GUIContent gamePath = new GUIContent("Game Path");
    }

    public MyCustomSettingsProvider(string path, SettingsScope scope = SettingsScope.User)
        : base(path, scope) { }

    public static bool IsSettingsAvailable()
    {
        return File.Exists(LuminaireSettings.SettingsPath);
    }

    public override void OnActivate(string searchContext, VisualElement rootElement)
    {
        customSettings = LuminaireSettings.GetSerializedSettings();
    }

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

    [SettingsProvider]
    public static SettingsProvider CreateMyCustomSettingsProvider()
    {
        if (IsSettingsAvailable())
        {
            var provider = new MyCustomSettingsProvider("Luminaire/", SettingsScope.User)
            {
                label = "FFXV",
                keywords = GetSearchKeywordsFromGUIContentProperties<Styles>()
            };

            return provider;
        }

        return null;
    }
}