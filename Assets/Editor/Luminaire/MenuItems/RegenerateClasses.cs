using Luminaire.ClassGeneration;
using System.IO;
using UnityEditor;
using UnityEngine;

public class RegenerateClasses
{
    private const string SchemaPath = "/Editor/Luminaire/ClassGeneration/ObjectTypes.json";
    private const string ClassTemplatePath = "/Editor/Luminaire/ClassGeneration/ClassTemplate.txt";
    private const string SetupTemplatePath = "/Editor/Luminaire/ClassGeneration/EntityModuleSetupTemplate.txt";

    [MenuItem("Luminaire/Developer/Regenerate Classes")]
    private static void OnRegenerateClasses()
    {
        var schema = File.ReadAllText(Application.dataPath + SchemaPath);
        var classTemplate = File.ReadAllText(Application.dataPath + ClassTemplatePath);
        var setupTemplate = File.ReadAllText(Application.dataPath + SetupTemplatePath);
        ClassGenerator.GenerateClasses(schema, classTemplate, setupTemplate);
        AssetDatabase.Refresh();
    }
}
