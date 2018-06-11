using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine;
using Vuforia;
 
public class DeployStageOnce : MonoBehaviour {
     
    public GameObject AnchorStage;
    private PositionalDeviceTracker _deviceTracker;
    private GameObject _previousAnchor;
    static int flag; 
     
    public void Start ()
    {
        if (AnchorStage == null)
        {
            Debug.Log("AnchorStage must be specified");
            return;
        }
 
        AnchorStage.SetActive(false);
        flag = 0;
    }
 
    public void Awake()
    {
        VuforiaARController.Instance.RegisterVuforiaStartedCallback(OnVuforiaStarted);
    }
 
    public void OnDestroy()
    {
        VuforiaARController.Instance.UnregisterVuforiaStartedCallback(OnVuforiaStarted);
    }
 
    private void OnVuforiaStarted()
    {
        _deviceTracker = TrackerManager.Instance.GetTracker<PositionalDeviceTracker>();
    }
 
    public void OnInteractiveHitTest(HitTestResult result)
    {
       
        if (result == null || AnchorStage == null)
        {
            Debug.LogWarning("Hit test is invalid or AnchorStage not set");
            return;
        }
 
        var anchor = _deviceTracker.CreatePlaneAnchor(Guid.NewGuid().ToString(), result);
 
        if ( anchor != null)
        {
            AnchorStage.transform.parent = anchor.transform;
            if (flag == 0){
            AnchorStage.transform.localPosition = Vector3.zero;
            AnchorStage.transform.localRotation = Quaternion.identity;
            flag = 1;
        }
            AnchorStage.SetActive(true);
            
        }
 
        if (_previousAnchor != null)
        {
            Destroy(_previousAnchor);
        }
 
        _previousAnchor = anchor;
    }
}