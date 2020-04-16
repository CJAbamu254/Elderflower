namespace GoogleARCore.Examples.HelloAR
{
    using System.Collections.Generic;
    using GoogleARCore;
    using GoogleARCore.Examples.Common;
    using UnityEngine;
    using UnityEngine.EventSystems;

#if UNITY_EDITOR
    // Set up touch input propagation while using Instant Preview in the editor.
    using Input = InstantPreviewInput;
#endif

    public class camerashoot : MonoBehaviour
    {
        // Update is called once per frame
        void FixedUpdate()
        {
            for (var i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    // Construct a ray from the current touch coordinates
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                    RaycastHit hit;
                    // Create a particle if hit
                    if (Physics.Raycast(ray, out hit))
                    {
                        hit.transform.gameObject.GetComponent<Destroy>().kill = true;
                    }
                }
            }
        }
    }
}
