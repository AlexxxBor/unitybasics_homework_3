using System;
using UnityEngine;

namespace Code
{
    public sealed class VectorExample : MonoBehaviour
    {
        public Transform TargetOne;
        public Transform TargetTwo;

        private void Start()
        {
            Vector2 vector2 = new Vector2(1, 2);
            Vector3 vector3 = new Vector3(1, 2, 3);
            Vector4 vector4 = new Vector4(1, 2, 3, 4);
            Vector2Int vector2Int = new Vector2Int(1, 2);
            Vector3Int vector3Int = new Vector3Int(1, 2, 3);
            DotProduct();
        }

        private void DotProduct()
        {
            Vector3 positionFirst = TargetOne.position;
            Vector3 positionSecond = TargetTwo.position;
            Transform primitive = GameObject.CreatePrimitive(PrimitiveType.Sphere).transform;
            //primitive.position = positionFirst + positionSecond;
            //primitive.position = Vector3.Dot(positionFirst, positionSecond) * Vector3.one;
            primitive.transform.position = Vector3.Cross(positionFirst, positionSecond);
            //https://docs.unity3d.com/ru/2019.4/Manual/UnderstandingVectorArithmetic.html
            primitive.transform.position = Vector3.Reflect(TargetTwo.position, Vector3.forward);
            //https://docs.unity3d.com/ScriptReference/Vector3.Reflect.html

        }

        private void Update()
        {
            DistanceTest();
            AngleTest();
        }

        private void DistanceTest()
        {
            if(Vector3.Distance(TargetTwo.position, TargetOne.position) <= 5)
            {
                Debug.Log("Close!");
            }
        }

        private void AngleTest()
        {
            if(Vector3.Angle(TargetTwo.forward, TargetOne.position - TargetTwo.position) <= 30)
            {
                Debug.Log("Visible!");
            }
        }
        
        public int ReturnNearestIndex(Vector3[] nodes, Vector3 destination)
        {
            var nearestDistance = Mathf.Infinity;
            var index = 0;
            var length = nodes.Length;
            for (var i = 0; i < length; i++)
            {
                var distanceToNode = (destination + nodes[i]).sqrMagnitude;
                if (!(nearestDistance > distanceToNode)) continue;
                nearestDistance = distanceToNode;
                index = i;
            }

            return index;
        }
        
        private void RotationExampleSix()
        {
            Vector2.Perpendicular(transform.position);
        }
    }
}
