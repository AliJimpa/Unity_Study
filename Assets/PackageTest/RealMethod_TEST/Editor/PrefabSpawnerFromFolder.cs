using UnityEngine;
using UnityEditor;

public class PrefabSpawnerFromFolder : EditorWindow
{
    private DefaultAsset folder;
    private Vector3 spawnPosition = Vector3.zero;
    private float spacing = 2f;

    [MenuItem("Tools/Spawn Prefabs From Folder")]
    public static void ShowWindow()
    {
        GetWindow<PrefabSpawnerFromFolder>("Spawn Prefabs");
    }

    private void OnGUI()
    {
        GUILayout.Label("Select Folder Containing Prefabs", EditorStyles.boldLabel);
        folder = (DefaultAsset)EditorGUILayout.ObjectField("Prefab Folder", folder, typeof(DefaultAsset), false);
        spawnPosition = EditorGUILayout.Vector3Field("Start Position", spawnPosition);
        spacing = EditorGUILayout.FloatField("Spacing", spacing);

        if (GUILayout.Button("Spawn Prefabs"))
        {
            if (folder == null)
            {
                Debug.LogError("Please select a folder containing prefabs.");
                return;
            }

            string folderPath = AssetDatabase.GetAssetPath(folder);
            SpawnPrefabsFromFolder(folderPath);
        }
    }

    private void SpawnPrefabsFromFolder(string folderPath)
    {
        string[] prefabGUIDs = AssetDatabase.FindAssets("t:Prefab", new[] { folderPath });
        Vector3 currentPosition = spawnPosition;

        foreach (string guid in prefabGUIDs)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);

            if (prefab != null)
            {
                GameObject instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                instance.transform.position = currentPosition;
                currentPosition += Vector3.right * spacing;
            }
        }

        Debug.Log($"Spawned {prefabGUIDs.Length} prefabs from folder: {folderPath}");
    }
}
