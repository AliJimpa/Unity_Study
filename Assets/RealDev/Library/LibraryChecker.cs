using UnityEngine;
using System.Collections.Generic;
using RealMethod;



public class LibraryChecker : MonoBehaviour
{
    public int[] SampleArray;
    public List<int> SampleList;
    public StringFloatDictionary SampleData;
    public int TargetIndex;

    [Button]
    private void IsValidArray()
    {
        print("IsValidArray: " + SampleArray.IsValidIndex(TargetIndex));
    }
    [Button]
    private void IsValidList()
    {
        print("IsValidList: " + SampleList.IsValidIndex(TargetIndex));
    }
    [Button]
    private void ShuffleArray()
    {
        SampleArray.Shuffle();
    }
    [Button]
    private void ShuffleList()
    {
        SampleList.Shuffle();
    }
    [Button]
    private void RandomArray()
    {
        print(SampleArray.GetRandom());
    }
    [Button]
    private void RandomList()
    {
        print(SampleList.GetRandom());
    }
    [Button]
    private void Wheel()
    {
        print(SampleData.Wheel());
    }

}
