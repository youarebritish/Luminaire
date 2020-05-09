
namespace Luminaire.MenuItems
{
    using Luminaire.Entity;
    using SQEX.Ebony.Framework.Entity;
    using System.IO;
    using UnityEditor;
    using UnityEngine;

    public static class ImportAsset
    {
        private const string ImportPath = "Assets/Mod/";

        [MenuItem("Luminaire/Import Entity Package")]
        private static void OnImportAsset()
        {
            // TODO pull out into a utility function
            var settings = AssetDatabase.LoadAssetAtPath<LuminaireSettings>(LuminaireSettings.SettingsPath);
            var gamePath = settings.GamePath;
            if (string.IsNullOrEmpty(gamePath))
            {
                EditorUtility.DisplayDialog("Game path not set", "Game path must be set before assets can be imported.", "OK");
                return;
            }

            if (!File.Exists(gamePath))
            {
                EditorUtility.DisplayDialog("Invalid game path", "Invalid game path. Make sure the game path points to a valid game executable.", "OK");
                return;
            }

            var assetPath = EditorUtility.OpenFilePanel("Import asset", gamePath, "exml");
            if (string.IsNullOrEmpty(assetPath))
            {
                return;
            }

            var fileContent = File.ReadAllBytes(assetPath);
            var loader = new EntityPackageXmlLoader();
            var package = loader.CreateEntityPackage(fileContent);

            var packageAsset = ScriptableObject.CreateInstance<EntityPackageAsset>();

            var destinationPath = MakeDestinationPath(Path.GetFileName(assetPath), package.sourcePath_);
            Directory.CreateDirectory(destinationPath);

            AssetDatabase.CreateAsset(packageAsset, destinationPath);
            AssetDatabase.SaveAssets();

            packageAsset.Package = package;
        }

        private static string MakeDestinationPath(string filename, string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath))
            {
                return $"{ImportPath}{filename}.asset";
            }

            return $"{ImportPath}{sourcePath}.asset";
        }
    }
}