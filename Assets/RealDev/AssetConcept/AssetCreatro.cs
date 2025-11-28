using RealMethod;
using UnityEngine;


public interface ISampleValue
{
    public int Val { get; }
    public void SetVal(int x);
}

public class AssetCreatro : MonoBehaviour
{
    public DataAsset dataAsset;
    public TemplateAsset templateAsset;
    public FileAsset fileAsset;
    public UniqueAsset uniqueAsset;
    public ConfigAsset configAsset;
    [Space]
    public PrimitiveAsset TargetAsset;



    [Button]
    private void CreateData()
    {
        TargetAsset = Spawn.Asset<SampleData>();
        ChangeValue(TargetAsset);
    }
    [Button]
    private void CreateTemplate()
    {
        TargetAsset = Spawn.Asset<SampleTemplate>();
        ChangeValue(TargetAsset);
    }
    [Button]
    private void CreateUnique()
    {
        TargetAsset = Spawn.Asset<SampleUnique>();
        ChangeValue(TargetAsset);
    }
    [Button]
    private void CreateFile()
    {
        TargetAsset = Spawn.Asset<SampleFile>();
        ChangeValue(TargetAsset);
    }
    [Button]
    private void CreateConfig()
    {
        TargetAsset = Spawn.Asset<SampleConfig>();
        ChangeValue(TargetAsset);
    }
    [Button]
    private void CloneData()
    {
        TargetAsset = Spawn.Clone(dataAsset);
        ChangeValue(TargetAsset);
    }
    [Button]
    private void CloneTemplate()
    {
        TargetAsset = Spawn.Clone(templateAsset);
        ChangeValue(TargetAsset);
    }
    [Button]
    private void CloneFile()
    {
        TargetAsset = Spawn.Clone(fileAsset);
        ChangeValue(TargetAsset);
    }
    [Button]
    private void CloneUnique()
    {
        TargetAsset = Spawn.Clone(uniqueAsset);
        ChangeValue(TargetAsset);
    }
    [Button]
    private void CloneConfig()
    {
        TargetAsset = Spawn.Clone(configAsset);
        ChangeValue(TargetAsset);
    }
    [Button]
    private void ReadTargetAsset()
    {
        ReadValue(TargetAsset);
    }


    public void ChangeValue(PrimitiveAsset ass)
    {
        print("LastValue " + ((ISampleValue)ass).Val);
        ((ISampleValue)ass).SetVal(100);
        print("NewValue " + ((ISampleValue)ass).Val);
    }
    public void ReadValue(PrimitiveAsset ass)
    {
        print("CurrentValue " + ((ISampleValue)ass).Val);
    }

}
