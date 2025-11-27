using System.Collections;
using RealMethod;
using UnityEngine;

public class CoroutineOrder : MonoBehaviour
{
    public EnumeratorManager EnumM;

    [Button]
    private void RunCoroutine()
    {
        StartCoroutine(StartTEST());
    }


    private IEnumerator A()
    {
        Debug.Log("A started");
        yield return new WaitForSeconds(1f);
        Debug.Log("A done");
    }

    private IEnumerator B()
    {
        Debug.Log("B started");
        yield return new WaitForSeconds(1f);
        Debug.Log("B done");
    }

    private IEnumerator C()
    {
        Debug.Log("C started");
        yield return new WaitForSeconds(1f);
        Debug.Log("C done");
    }

    private IEnumerator StartTEST()
    {
        yield return RM_Coroutine.WaitForCoroutine(this, A());
        yield return RM_Coroutine.WaitForCoroutine(this, B());
        yield return RM_Coroutine.WaitForCoroutine(this, C());

        Debug.Log("All coroutines done in sequence.");
    }

}
