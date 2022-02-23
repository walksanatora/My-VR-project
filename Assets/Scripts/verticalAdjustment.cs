using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using Unity.XR.CoreUtils;

public class verticalAdjustment : MonoBehaviour
{
    public InputActionReference yAxisRight = null;
    public InputActionReference AButton = null;
    public XROrigin XROriginObj;

    // Start is called before the first frame update
    void Start()
    {
        AButton.action.started += StartGame;
    }

    public void StartGame(InputAction.CallbackContext ctx){
        GlobalValues.YOffset = XROriginObj.CameraYOffset;
        SceneManager.LoadScene("Expierence");
    }

    // Update is called once per frame
    void Update()
    {
        float current = XROriginObj.CameraYOffset;
        float newOffset = current + yAxisRight.action.ReadValue<float>();
        XROriginObj.CameraYOffset = newOffset;
        GlobalValues.YOffset = newOffset;
    }
}
