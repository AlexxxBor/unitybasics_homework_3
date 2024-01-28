using NUnit.Framework;
using UnityEngine;
using static Sample.LessonVectors;

namespace Tests
{
    [TestFixture]
    public sealed class LessonVectorsTests
    {
        [Test]
        public void IsPointInCircleTest()
        {
            Assert.IsTrue(IsPointInCircle(Vector2.zero, 2, new Vector2(1, 0)));
            Assert.IsTrue(IsPointInCircle(Vector2.zero, 2, new Vector2(2, 0)));
            Assert.IsFalse(IsPointInCircle(Vector2.zero, 2, new Vector2(3, 0)));
        }

        [Test]
        public void IsPointOnLineTest()
        {
            Assert.IsTrue(IsPointOnLine(Vector2.zero, new Vector2(2, 2), new Vector2(1, 1)));
            Assert.IsFalse(IsPointOnLine(Vector2.zero, new Vector2(2, 0), new Vector2(1, 1)));
            Assert.IsTrue(IsPointOnLine(Vector2.zero, new Vector2(2, 0), Vector2.zero));
            Assert.IsFalse(IsPointOnLine(Vector2.zero, new Vector2(2, 0), new Vector2(-0.1f, 0)));
        }

        [Test]
        public void PointRelativeLineTest()
        {
            Assert.AreEqual(0, PointRelativeLine(new Vector2(0, 1), new Vector2(0, 3), new Vector2(0, 0)));
            Assert.AreEqual(1, PointRelativeLine(new Vector2(0, 0), new Vector2(0, 3), new Vector2(1, 2)));
            Assert.AreEqual(-1, PointRelativeLine(new Vector2(0, 0), new Vector2(0, 3), new Vector2(-1, 2)));
            Assert.AreEqual(0, PointRelativeLine(new Vector2(0, 0), new Vector2(2, 2), new Vector2(1, 1)));
            Assert.AreEqual(1, PointRelativeLine(new Vector2(0, 0), new Vector2(2, 2), new Vector2(2, 0)));
            Assert.AreEqual(-1, PointRelativeLine(new Vector2(0, 0), new Vector2(2, 2), new Vector2(0, 2)));
        }


        [Test]
        public void CircleInsideCircleTest()
        {
            Assert.IsTrue(CircleInsideCircle(Vector2.zero, 1, Vector2.zero, 2));
            Assert.IsFalse(CircleInsideCircle(Vector2.zero, 2, Vector2.zero, 1));
            Assert.IsTrue(CircleInsideCircle(new Vector2(0, 1), 1, Vector2.zero, 2));
            Assert.IsFalse(CircleInsideCircle(new Vector2(0, 1.1f), 1, Vector2.zero, 2));
        }

        [Test]
        public void IsPointInRectangleTest()
        {
            Assert.IsTrue(IsPointInRectangle(Vector2.zero, new Vector2(2, 2), new Vector2(1, 1)));
            Assert.IsTrue(IsPointInRectangle(Vector2.zero, new Vector2(2, 2), new Vector2(2, 2)));
            Assert.IsFalse(IsPointInRectangle(Vector2.zero, new Vector2(2, 2), new Vector2(3, 3)));
            Assert.IsTrue(IsPointInRectangle(new Vector2(1, 4), new Vector2(5, 2), new Vector2(2, 1.5f)));
            Assert.IsTrue(IsPointInRectangle(Vector2.zero, new Vector2(2, 0), new Vector2(1, 0)));
            Assert.IsTrue(IsPointInRectangle(Vector2.zero, Vector2.zero, Vector2.zero));
        }

        [Test]
        public void KingMoveNumberTest()
        {
            Assert.AreEqual(0, KingMoveNumber(new Vector2Int(5, 3), new Vector2Int(5, 3)));
            Assert.AreEqual(1, KingMoveNumber(new Vector2Int(3, 2), new Vector2Int(2, 1)));
            Assert.AreEqual(2, KingMoveNumber(new Vector2Int(7, 8), new Vector2Int(6, 6)));
            Assert.AreEqual(6, KingMoveNumber(new Vector2Int(1, 8), new Vector2Int(7, 8)));
            Assert.AreEqual(7, KingMoveNumber(new Vector2Int(1, 1), new Vector2Int(8, 8)));
        }

        [Test]
        public void RayCircleIntersectTest()
        {
            Assert.IsTrue(RayCircleIntersect(new Ray(Vector3.zero, Vector3.up), new Vector3(0, 4, 0), 1));
            Assert.IsFalse(RayCircleIntersect(new Ray(Vector3.zero, Vector3.zero), new Vector3(0, 4, 0), 1));
            Assert.IsFalse(RayCircleIntersect(new Ray(new Vector3(0, 20, 0), Vector3.up), new Vector3(0, 4, 0), 2));
            Assert.IsTrue(RayCircleIntersect(new Ray(new Vector3(1, 0, 0), Vector3.up), new Vector3(0, 4, 0), 1));
            Assert.IsTrue(RayCircleIntersect(new Ray(Vector3.zero, new Vector3(1, 1, 1)), new Vector3(5, 5, 5), 0.5f));
            Assert.IsTrue(RayCircleIntersect(new Ray(Vector3.zero, new Vector3(1, 1, 1)), new Vector3(5, 5, 5), 0));
            Assert.IsFalse(RayCircleIntersect(new Ray(Vector3.zero, new Vector3(-1, -1, -1)), new Vector3(5, 5, 5), 2));
            Assert.IsFalse(RayCircleIntersect(new Ray(Vector3.zero, Vector3.up), Vector3.zero, 1));
            Assert.IsFalse(RayCircleIntersect(new Ray(new Vector3(1, 0, 0), Vector3.left), Vector3.zero, 1));
            Assert.IsTrue(RayCircleIntersect(new Ray(new Vector3(2, 0, 0), Vector3.left), Vector3.zero, 1));
        }
    }
}