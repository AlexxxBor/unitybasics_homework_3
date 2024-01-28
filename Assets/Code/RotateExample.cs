using System;
using UnityEngine;

namespace Code
{
    public sealed class RotateExample : MonoBehaviour
    {
        public Transform Target;

        private void Update()
        {
            Vector3 positionNormalized = Target.position.normalized;
            float angle = Mathf.Acos(positionNormalized.z) * Mathf.Rad2Deg;
            transform.Rotate(Vector3.up, angle - transform.rotation.eulerAngles.y);
        }

        private void Start()
        {
            Vector3 newRotation = new Vector3(0, 90, 0);
            transform.eulerAngles = newRotation;  
            transform.rotation = Quaternion.Euler(newRotation);
        }
        
        
        private void RotationExampleThree()
        {
            transform.rotation = Quaternion.LookRotation(Target.position, Vector3.up);  // 1
            transform.LookAt(Target.position, Vector3.up); // 2
        }
        
        private void RotationExampleFour()
        {
            Vector3 direction = Target.position - transform.position;
            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 1);
        }
        
        private void RotationExampleFive()
        {
            Vector3 direction = Target.position - transform.position;
            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 1);
        }
    }
}
