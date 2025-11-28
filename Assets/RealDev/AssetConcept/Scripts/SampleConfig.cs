using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "SampleConfig", menuName = "Mustard/SampleConfig", order = 0)]
public class SampleConfig : ConfigAsset, ISampleValue
{
    public bool kamel { get; }
    [SerializeField]
    private int myval;
    public int Val => myval;
    void ISampleValue.SetVal(int x)
    {
        myval = x;
    }
}