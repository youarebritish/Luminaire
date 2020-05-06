using System.IO;
using UnityEditor;
using UnityEngine;

public static class RegenerateClasses
{
    private const string SchemaPath = "/Editor/Luminaire/ClassGeneration/ObjectTypes.json";

    [MenuItem("Luminaire/Regenerate Classes")]
    private static void OnRegenerateClasses()
    {
        var schema = File.ReadAllText(Application.dataPath + SchemaPath);
        ClassGenerator.GenerateClasses(schema, "");
    }
}
