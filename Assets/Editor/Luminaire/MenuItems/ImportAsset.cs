using Black.Entity.Actor;
using Black.Sequence.Action.Actor;
using Ebony.Framework.Entity;
using Ebony.Framework.Node;
using Ebony.Framework.Sequence;
using Ebony.Framework.Sequence.Event;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

public static class ImportAsset
{
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

        // TODO refactor
        Luminous.Core.Object.Object.SetupObjectType();
        Ebony.Framework.Entity.Entity.SetupObjectType();
        EntityGroup.SetupObjectType();
        EntityPackageReference.SetupObjectType();
        EntityPackage.SetupObjectType();
        CharacterPackage.SetupObjectType();
        GraphNode.SetupObjectType();
        SequenceNode.SetupObjectType();
        SequenceActivatableNode.SetupObjectType();
        SequenceEventSequenceStarted.SetupObjectType();
        SequenceEvent.SetupObjectType();
        SequneceActionActorSetMaterialFloatParameter.SetupObjectType();
        GraphTriggerInputPin.SetupObjectType();
        GraphVariableInputPin.SetupObjectType();
        GraphTriggerOutputPin.SetupObjectType();

        var fileContent = File.ReadAllBytes(assetPath);
        var loader = new EntityPackageXmlLoader();
        var package = loader.CreateEntityPackage(fileContent);

        var packageAsset = ScriptableObject.CreateInstance<EntityPackageAsset>();

        var destinationPath = MakeDestinationPath(assetPath, gamePath);
        Directory.CreateDirectory(destinationPath);

        AssetDatabase.CreateAsset(packageAsset, destinationPath);
        AssetDatabase.SaveAssets();

        packageAsset.Package = package;
    }

    private static string MakeDestinationPath(string assetPath, string gamePath)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("Assets/");

        var relativePath = assetPath.Substring(Path.GetDirectoryName(gamePath).Length);
        stringBuilder.Append(relativePath);
        stringBuilder.Append(".asset");

        return stringBuilder.ToString();
    }
}
