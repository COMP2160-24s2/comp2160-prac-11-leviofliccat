using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{
    private Actions actions;
    private InputAction scrollAction;
    private float zoom;
    
    void Awake()
    {
        actions = new Actions();
        scrollAction = actions.camera.zoom;
        scrollAction.performed += OnScroll;
    }

    void OnEnable()
    {
        actions.camera.Enable();
    }

    void OnDisable()
    {
        actions.camera.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void OnScroll(InputAction.CallbackContext context)
    {
        zoom = scrollAction.ReadValue<float>() / 120;
        if (Camera.main.orthographic)
        {
            Camera.main.orthographicSize += zoom;
        } else
        {
            Camera.main.fieldOfView += zoom;
        }
    }
}
