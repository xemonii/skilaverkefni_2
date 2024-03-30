using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hlutursnu : MonoBehaviour
{
    void Update()
    {
        // snýr hlutnum um y-ásinn á jöfnum hraða
        transform.Rotate(new Vector3(0, 80, 0) * Time.deltaTime);
    }
}