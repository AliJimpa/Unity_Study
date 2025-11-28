using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "SampleUnique", menuName = "Mustard/SampleUnique", order = 0)]
public class SampleUnique : UniqueAsset, ISampleValue
{
    public int myval;
    public int Val => myval;

    public void SetVal(int x)
    {
        myval = x;
    }
}