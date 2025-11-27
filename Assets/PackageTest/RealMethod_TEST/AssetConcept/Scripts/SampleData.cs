using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "SampleData", menuName = "Mustard/SampleData", order = 0)]
public class SampleData : DataAsset, ISampleValue
{
    public int myval;
    public int Val => myval;
    public void SetVal(int x)
    {
        myval = x;
    }
}