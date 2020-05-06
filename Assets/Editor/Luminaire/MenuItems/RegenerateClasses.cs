using System.IO;
using UnityEditor;
using UnityEngine;

public static class RegenerateClasses
{
    private const string SchemaPath = "/Editor/Luminaire/ClassGeneration/ObjectTypes.json";
    private const string TemplatePath = "/Editor/Luminaire/ClassGeneration/ClassTemplate.txt";

    [MenuItem("Luminaire/Regenerate Classes")]
    private static void OnRegenerateClasses()
    {
        var schema = File.ReadAllText(Application.dataPath + SchemaPath);
        var template = File.ReadAllText(Application.dataPath + TemplatePath);
        ClassGenerator.GenerateClasses(schema, template);
    }
}
