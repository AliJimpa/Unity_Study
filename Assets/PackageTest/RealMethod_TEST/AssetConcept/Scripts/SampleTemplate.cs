using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "SampleTemplate", menuName = "Mustard/SampleTemplate", order = 0)]
public class SampleTemplate : TemplateAsset, ISampleValue
{
    public int myval;
    public int Val => myval;
    public void SetVal(int x)
    {
        myval = x;
    }
}