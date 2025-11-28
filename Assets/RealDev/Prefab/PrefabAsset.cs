using UnityEngine;
using RealMethod;

[CreateAssetMenu(fileName = "PrefabAsset", menuName = "Mustard/PrefabAsset")]
public class PrefabAsset : ScriptableObject
{
    [SerializeField]
    private Prefab sampleprefab;
}
