using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class AIC : MonoBehaviour {

    [SerializeField] private AIV _augmentedImageVisualizer;

    private readonly Dictionary<int, AIV> _visualizers = new Dictionary<int, AIV>();

    private readonly List<AugmentedImage> _images = new List<AugmentedImage>();

    private void Update()
    {
        if(Session.Status != SessionStatus.Tracking)
        {
            return;
        }

        Session.GetTrackables(_images, TrackableQueryFilter.Updated);
        VisualizeTrackables();
    }

    private void VisualizeTrackables()
    {
        foreach(var image in _images)
        {
            var visualizer = GetVisualizer(image);

            if(image.TrackingState == TrackingState.Tracking && visualizer == null)
            {
                AddVisualizer(image);
            }
            else if(image.TrackingState == TrackingState.Stopped && visualizer != null)
            {
                RemoveVisualizer(image, visualizer);
            }
        }
    }

    private void RemoveVisualizer(AugmentedImage image, AIV visualizer)
    {
        _visualizers.Remove(image.DatabaseIndex);
        Destroy(visualizer.gameObject);
    }

    private void AddVisualizer(AugmentedImage image)
    {
        var anchor = image.CreateAnchor(image.CenterPose);
        var visualizer = Instantiate(_augmentedImageVisualizer, anchor.transform);
        visualizer.Image = image;
        _visualizers.Add(image.DatabaseIndex, visualizer);
    }

    private AIV GetVisualizer(AugmentedImage image)
    {
        AIV visualizer;
        _visualizers.TryGetValue(image.DatabaseIndex, out visualizer);
        return visualizer;
    }
}
