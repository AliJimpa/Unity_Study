using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public int doorID;
    private void OnDestroy() {
        Operator.instance.Iamdone(doorID);
        if (doorID == 3)
        {
            Operator.instance.Imindor3();
        }
    }
}
