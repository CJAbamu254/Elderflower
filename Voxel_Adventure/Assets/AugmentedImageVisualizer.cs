namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;

    public class AugmentedImageVisualizer : MonoBehaviour
    {
        public AugmentedImage Image;

        public GameObject levelprefab;

        void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                return;
            }

            if(!levelprefab.activeInHierarchy)
            {
                levelprefab.SetActive(true);
            }

            transform.localScale = new Vector3(Image.ExtentX, Image.ExtentZ, 1);
        }

    }
}