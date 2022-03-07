using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class OffsetApplier : MonoBehaviour
{
    
    public XROrigin XROriginObj;
    public Transform CameraPosition;
    public float cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        float current = XROriginObj.CameraYOffset;
        float camY = CameraPosition.position.y;
        float offset = cameraOffset - camY;
        float newYOffset = current + offset;
        XROriginObj.CameraYOffset = newYOffset;
    }
}
