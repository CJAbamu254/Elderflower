namespace GoogleARCore.Examples.AugmentedImage
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using UnityEngine;
    using UnityEngine.UI;

    public class AugmentedImageController : MonoBehaviour
    {
        [SerializeField] private AugmentedImageVisualizer _augmentedImageVisualiser;

        private readonly Dictionary<int, AugmentedImageVisualizer> _visualizers;

        private readonly List<AugmentedImage> _image;
        
        // Update is called once per frame
        void Update()
        {
            if (Session.Status != SessionStatus.Tracking)
            {
                return;
            }

            Session.GetTrackables(_image, TrackableQueryFilter.All);
            VisualiseTrackables();
        }

        void VisualiseTrackables()
        {
            foreach(var image in _image)
            {
                var visualizer = GetVisualizer(image);

                if (image.TrackingState == TrackingState.Tracking && visualizer == null)
                {
                    AddVisualizer(image);
                }
                else if (image.TrackingState == TrackingState.Stopped && visualizer != null)
                {
                    RemoveVisualizer(image, visualizer);
                }
            }
        }

        void RemoveVisualizer(AugmentedImage image, AugmentedImageVisualizer visualizer)
        {
            _visualizers.Remove(image.DatabaseIndex);
            Destroy(visualizer.gameObject);
        }

        void AddVisualizer(AugmentedImage image)
        {
            var anchor = image.CreateAnchor(image.CenterPose);
            var visualizer = Instantiate(_augmentedImageVisualiser, anchor.transform);
            visualizer.Image = image;
            _visualizers.Add(image.DatabaseIndex, visualizer);
        }

        private AugmentedImageVisualizer GetVisualizer(AugmentedImage image)
        {
            AugmentedImageVisualizer visualizer;
            _visualizers.TryGetValue(image.DatabaseIndex, out visualizer);
            return visualizer;
        }
    }
}
