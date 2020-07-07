using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class PlaneMgr : MonoBehaviour {

    public Camera arCamera;
    public GameObject andy;

    void Start()
    {
        // ARCamera는 Camera.main값을 이렇게 받아와야 함
        arCamera = Camera.main;
    }

    void Update()
    {
        Touch touch = Input.GetTouch(0);
        if (Input.touchCount > 0 && touch.phase == TouchPhase.Began)
        {
            TrackableHit hit;
            TrackableHitFlags flags = TrackableHitFlags.PlaneWithinPolygon
                                    | TrackableHitFlags.FeaturePointWithSurfaceNormal;

            // ARCore레이캐스트
            if (Frame.Raycast(touch.position.x, touch.position.y, flags, out hit))
            {
                var anchor = hit.Trackable.CreateAnchor(hit.Pose);
                Instantiate(andy, hit.Pose.position, hit.Pose.rotation, anchor.transform);
            }
        }
    }
}
