
namespace Luminaire.MenuItems
{
    using Luminaire.Entity;
    using SQEX.Ebony.Framework.Entity;
    using System.IO;
    using UnityEditor;
    using UnityEngine;
    using UnityEditor.SceneManagement;
    using UnityEngine.SceneManagement;
    using SQEX.Luminous.Core.Object;

    public static class ImportAsset
    {
        private const string ImportPath = "Assets/Mod/";

        [MenuItem("Luminaire/Import Entity Package")]
        private static void OnImportAsset()
        {
            // TODO pull out into a utility function
            var settings = LuminaireSettings.Instance;
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
            // make a new function called after this line which takes the package and generates the scene
            var saveScenePath = SaveScenePath(Path.GetFileName(assetPath), package.sourcePath_);

            SceneGenerator(Path.GetFileName(assetPath), saveScenePath);

            Debug.Log("Path.GetFileName(assetPath): " + Path.GetFileName(assetPath));

            for (var i = 0; i < package.loadedObjects_.Count; i++)
            {
                var newGameObject = new GameObject(package.loadedObjectNames_[i]);

                if (i == 0) //object 0
                {
                    var componentSceneManager = newGameObject.AddComponent<LuminousSceneManager>();
                }

                var component = newGameObject.AddComponent<LuminousObject>();
                component.Entity = package.loadedObjects_[i];
                component.Entity.SetupGameObject(newGameObject);
            }

            var packageAsset = ScriptableObject.CreateInstance<EntityPackageAsset>();

            var destinationPath = MakeDestinationPath(Path.GetFileName(assetPath), package.sourcePath_);
            Directory.CreateDirectory(destinationPath);

            AssetDatabase.CreateAsset(packageAsset, destinationPath);
            AssetDatabase.SaveAssets();

            packageAsset.Package = package;
        }

        private static void SceneGenerator(string packageName, string saveScenePath)
        {
            var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);            
            EditorSceneManager.SaveScene(newScene, saveScenePath);
        }

        private static string MakeDestinationPath(string filename, string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath))
            {
                return $"{ImportPath}{filename}.asset";
            }

            return $"{ImportPath}{sourcePath}.asset";
        }
        private static string SaveScenePath(string filename, string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath))
            {
                return $"{ImportPath}{filename}.unity";
            }

            return $"{ImportPath}{sourcePath}.unity";
        }

    }
}