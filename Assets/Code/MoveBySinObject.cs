using UnityEngine;

namespace Code
{
    public sealed class MoveBySinObject : MonoBehaviour
    {
        public float Speed = 3.5f;
        public float Radius = 5.0f;
        private float _movable;

        private void Update()
        {
            _movable += Time.deltaTime * Speed;
            float x = Mathf.Sin(_movable) * Radius;
            float y = Mathf.Cos(_movable / 2) * Radius;
            transform.position = new Vector3(x, y, transform.position.z);
        }
    }
}
