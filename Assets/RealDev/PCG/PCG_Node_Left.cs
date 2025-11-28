using RealMethod;
using UnityEngine;

public class PCG_Node_Left : PCGRequest
{
    protected override void Initialized()
    {
        Debug.Log("Ali");
    }
    public override PCGRequestResult Process(ref PCGData Context, string StringParam, float FloatParam, Vector3 VectorParam)
    {
        Debug.LogWarning(Context.PrefabID);
        return PCGRequestResult.Success;
    }


}
