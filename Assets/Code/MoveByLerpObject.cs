using UnityEngine;

namespace Code
{
    public sealed class MoveByLerpObject : MonoBehaviour
    {
        public float Speed = 0.5f;
        public Transform StartPoint;
        public Transform EndPoint;
        public Transform Target;

        private void Start()
        {
            Target.position = StartPoint.position;
        }

        private void Update()
        {
            Target.position = Vector3.Lerp(Target.position, EndPoint.position, Speed * Time.deltaTime);
        }
    }
}
