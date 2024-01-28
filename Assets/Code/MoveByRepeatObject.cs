using System;
using UnityEngine;

namespace Code
{
    public sealed class MoveByRepeatObject : MonoBehaviour
    {
        private void Update()
        {
            float x = Mathf.PingPong(Time.time, 3);
            float y = Mathf.Repeat(Time.time, 3);
            transform.position = new Vector3(x, y, transform.position.z);
        }
    }
}
