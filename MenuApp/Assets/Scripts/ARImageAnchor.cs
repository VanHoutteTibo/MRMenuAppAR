using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARImageAnchor : MonoBehaviour
{
    public string ReferenceImageName;
    private ARTrackedImageManager _TrackedImageManager;
    public Renderer rend;

    private void Awake()
    {
        _TrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    private void OnEnable()
    {
        if (_TrackedImageManager != null)
        {
            _TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
        }
    }

    private void OnDisable()
    {
        if (_TrackedImageManager != null)
        {
            _TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
        }
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs e)
    {
        
        foreach (var trackedImage in e.added)
        {
            Debug.Log($"Tracked image detected: {trackedImage.referenceImage.name} with size: {trackedImage.size}");
        }
        
        UpdateTrackedImages(e.added);
        UpdateTrackedImages(e.updated);
    }

    private void UpdateTrackedImages(IEnumerable<ARTrackedImage> trackedImages)
    {
        // If the same image (ReferenceImageName)
        var trackedImage =
            trackedImages.FirstOrDefault(x => x.referenceImage.name == ReferenceImageName);
        if (trackedImage == null)
        {
            return;
        }

        if (trackedImage.trackingState != TrackingState.None)
        {
            var trackedImageTransform = trackedImage.transform;
            gameObject.GetComponent<Renderer>().enabled = true;
            transform.SetPositionAndRotation(trackedImageTransform.position, trackedImageTransform.rotation);
            if(gameObject.tag == "taco")
            {
                transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            }
            else
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            
        }
    }
}