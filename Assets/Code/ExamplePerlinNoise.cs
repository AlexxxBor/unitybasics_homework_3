using UnityEngine;

namespace Code
{
    public sealed class ExamplePerlinNoise : MonoBehaviour
    {
        public float Multiplier = 5;
        public float Refinement = 0.3f;
        public int Count = 50;

        private void Start()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    float y = Mathf.PerlinNoise(i * Refinement, j * Refinement) * Multiplier;
                    var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(i, y, j);
                    cube.AddComponent<ExampleRandom>();
                }
            }
        }
    }
}
