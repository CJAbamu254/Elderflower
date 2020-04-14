using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class LevelPositioner : MonoBehaviour
{
    private Camera firstPersonCamera;
    private Anchor anchor;
    private DetectedPlane detectedPlane;
    private bool once;

    void Start()
    {
        firstPersonCamera = Camera.main;

        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
    }

    private void Update()
    {
        if (Session.Status != SessionStatus.Tracking)
        {
            return;
        }

        if (detectedPlane == null)
        {
            return;
        }

        while (detectedPlane.SubsumedBy != null)
        {
            detectedPlane = detectedPlane.SubsumedBy;
        }

        transform.LookAt(firstPersonCamera.transform);

    }

    public void SetSelectedPlane(DetectedPlane detectedPlane)
    {
        this.detectedPlane = detectedPlane;

        if (once == false)
        {
            CreateAnchor();
            once = true;
        }
    }

    void CreateAnchor()
    {

        // Create the position of the anchor by raycasting a point towards
        // the top of the screen.
        Vector2 pos = new Vector2(Screen.width * .5f, Screen.height * .90f);
        Ray ray = firstPersonCamera.ScreenPointToRay(pos);
        Vector3 anchorPosition = ray.GetPoint(5f);

        // Create the anchor at that point.
        if (anchor != null)
        {
            DestroyObject(anchor);
        }
        anchor = detectedPlane.CreateAnchor(
            new Pose(anchorPosition, Quaternion.identity));

        // Attach the scoreboard to the anchor.
        transform.position = anchorPosition;
        transform.SetParent(anchor.transform);

        // Finally, enable the renderers.
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.enabled = true;
        }
    }
}