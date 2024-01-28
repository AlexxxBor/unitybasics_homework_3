using UnityEngine;

namespace Code
{
    public sealed class Example
    {
        private void IsEqual(float playerHp, float enemyHp)
        {
            if (playerHp == enemyHp)
            {
                // win
            }
            float epsilon = 0.0001f;
            float epsilonByMathf = Mathf.Epsilon;
            if (Mathf.Abs(playerHp - enemyHp) < epsilonByMathf)
            {
                // win
            }

            if (Mathf.Approximately(playerHp, enemyHp))
            {
                // win
            }
        }

        private int GetMaxOrMin(int a, int b, int c, int i, bool isMax)
        {
            return isMax ? Mathf.Max(a, b, c, i) : Mathf.Min(a, b, c, i);
        }
    }
}
