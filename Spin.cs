using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hlutursnu : MonoBehaviour
{
    void Update()
    {
        // sn�r hlutnum um y-�sinn � j�fnum hra�a
        transform.Rotate(new Vector3(0, 80, 0) * Time.deltaTime);
    }
}