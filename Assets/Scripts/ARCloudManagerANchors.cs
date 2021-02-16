using Google.XR.ARCoreExtensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;

public class UnityEventResolver : UnityEvent<Transform> { };
public class ARCloudManagerANchors : MonoBehaviour
{

    [SerializeField]
    private Camera arCam = null;

    [SerializeField]
    private float timeOut = 5f;

    private ARAnchorManager anchorMan;

    private ARCloudAnchor cloudAnchor;

    public static ARAnchor pendingHost = null;

    private UnityEventResolver resolver = null;


    private void Awake()
    {
        //resolver = new UnityEventResolver();
        //resolver.AddListener((t)) => objectScript.RecreatePlacement((t));

    }

private Pose getCamPose()
    {
        return new Pose(arCam.transform.position, arCam.transform.rotation);
    }

    public static void QueueAnchor(ARAnchor anchor)
    {
        pendingHost = anchor;
    }

    public void SendAncher()
    {
        cloudAnchor = anchorMan.HostCloudAnchor(pendingHost, 1);
        if(cloudAnchor == null)
        {
            GameObject.Find("DebugText").GetComponent<TextMesh>().text = "Error on cloud";
        }
    }

    public void GetAnchors()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //Check if hosted
        if(cloudAnchor.cloudAnchorState == CloudAnchorState.Success)
        {
            GameObject.Find("DebugText").GetComponent<TextMesh>().text = "Object in cloud";

        }
        
    }
}
