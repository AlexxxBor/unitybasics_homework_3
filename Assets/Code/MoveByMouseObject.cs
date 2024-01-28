using UnityEngine;

namespace Code
{
    public sealed class MoveByMouseObject : MonoBehaviour
    {
        public Camera Camera;

        private void Update()
        {
            Vector3 screenToWorldPoint = Camera.ScreenToWorldPoint(Input.mousePosition + Vector3.forward);

            screenToWorldPoint.x = Mathf.Ceil(screenToWorldPoint.x);
            screenToWorldPoint.y = Mathf.Round(screenToWorldPoint.y);
            transform.position = new Vector3(screenToWorldPoint.x, screenToWorldPoint.y, transform.position.z);
        }
    }
}
