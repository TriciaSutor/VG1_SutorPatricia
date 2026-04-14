using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SplitScreen
{
    public class CameraController : MonoBehaviour
    {
        // Outlets
        public Transform target;

        // Configuration
        public float smoothness;
        public Vector3 offset;

        // State Tracking
        Vector3 _velocity;

        // Start is called before the first frame update
        void Start()
        {
            if (target) {
                offset = transform.position - target.position; 
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (target) {
                transform.position = Vector3.SmoothDamp(
                    transform.position, 
                    target.position + offset, 
                    ref _velocity, 
                    smoothness
                );
            }
        }
    }
}