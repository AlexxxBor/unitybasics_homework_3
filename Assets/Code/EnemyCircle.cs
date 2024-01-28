using UnityEngine;

namespace Code
{
    public sealed class EnemyCircle : MonoBehaviour
    {
        public GameObject EnemyPrefab;
        public float Distance = 2;
        public float Angle = 360;
        public int Count = 15;
        
        private void Start()
        {
            Vector3 point = transform.position;
            Angle *= Mathf.Deg2Rad;
            for (int i = 0; i < Count; i++)
            {
                float z = transform.position.z + Mathf.Cos(Angle / Count * i) * Distance;
                float x = transform.position.x + Mathf.Sin(Angle / Count * i) * Distance;
                point.x = x;
                point.z = z;
                Instantiate(EnemyPrefab, point, Quaternion.identity);
            }
        }
    }
}
