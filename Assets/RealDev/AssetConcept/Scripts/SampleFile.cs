using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "SampleFile", menuName = "Mustard/SampleFile", order = 0)]
public class SampleFile : FileAsset, ISampleValue
{
    public int myval;
    public int Val => myval;
    public void SetVal(int x)
    {
        myval = x;
    }
}