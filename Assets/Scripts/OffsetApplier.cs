using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class OffsetApplier : MonoBehaviour
{
    
    public XROrigin XROriginObj;
    // Start is called before the first frame update
    void Start()
    {
        float current = XROriginObj.CameraYOffset;
        float newOffset = current + GlobalValues.YOffset;
        XROriginObj.CameraYOffset = newOffset * Time.deltaTime;
    }
}
