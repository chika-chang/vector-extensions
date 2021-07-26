using NUnit.Framework;
using UnityEngine;

namespace Chika.Extensions.Tests {
    public class VectorExtensionsTests {
        [Test]
        public void Change_X_Of_Vector2_With_Value(
            [Random(float.MinValue, float.MaxValue, 3)]
            float x,
            [Random(float.MinValue, float.MaxValue, 3)]
            float y,
            [Random(float.MinValue, float.MaxValue, 3)]
            float value
        ) {
            var vector = new Vector2(x, y);
            var expected = new Vector2(value, y);
            Assert.That(vector.ChangeX(value), Is.EqualTo(expected));
        }

        [Test]
        public void Change_Y_Of_Vector2_With_Value(
            [Random(float.MinValue, float.MaxValue, 3)]
            float x,
            [Random(float.MinValue, float.MaxValue, 3)]
            float y,
            [Random(float.MinValue, float.MaxValue, 3)]
            float value
        ) {
            var vector = new Vector2(x, y);
            var expected = new Vector2(x, value);
            Assert.That(vector.ChangeY(value), Is.EqualTo(expected));
        }
        
        [Test]
        public void Change_X_Of_Vector3_With_Value(
            [Random(float.MinValue, float.MaxValue, 3)]
            float x,
            [Random(float.MinValue, float.MaxValue, 3)]
            float y,
            [Random(float.MinValue, float.MaxValue, 3)]
            float z,
            [Random(float.MinValue, float.MaxValue, 3)]
            float value
        ) {
            var vector = new Vector3(x, y, z);
            var expected = new Vector3(value, y, z);
            Assert.That(vector.ChangeX(value), Is.EqualTo(expected));
        }

        [Test]
        public void Change_Y_Of_Vector3_With_Value(
            [Random(float.MinValue, float.MaxValue, 3)]
            float x,
            [Random(float.MinValue, float.MaxValue, 3)]
            float y,
            [Random(float.MinValue, float.MaxValue, 3)]
            float z,
            [Random(float.MinValue, float.MaxValue, 3)]
            float value
        ) {
            var vector = new Vector3(x, y, z);
            var expected = new Vector3(x, value, z);
            Assert.That(vector.ChangeY(value), Is.EqualTo(expected));
        }

        [Test]
        public void Change_Z_Of_Vector3_With_Value(
            [Random(float.MinValue, float.MaxValue, 3)]
            float x,
            [Random(float.MinValue, float.MaxValue, 3)]
            float y,
            [Random(float.MinValue, float.MaxValue, 3)]
            float z,
            [Random(float.MinValue, float.MaxValue, 3)]
            float value
        ) {
            var vector = new Vector3(x, y, z);
            var expected = new Vector3(x, y, value);
            Assert.That(vector.ChangeZ(value), Is.EqualTo(expected));
        }
        
        [Test]
        public void Convert_XY_Of_Vector3_To_Vector2(
            [Random(float.MinValue, float.MaxValue, 3)]
            float x,
            [Random(float.MinValue, float.MaxValue, 3)]
            float y,
            [Random(float.MinValue, float.MaxValue, 3)]
            float z
        ) {
            var vector = new Vector3(x, y, z);
            var expected = new Vector2(x, y);
            Assert.That(vector.ToVector2(), Is.EqualTo(expected));
        }

        [Test]
        public void Convert_YZ_Of_Vector3_To_Vector2(
            [Random(float.MinValue, float.MaxValue, 3)]
            float x,
            [Random(float.MinValue, float.MaxValue, 3)]
            float y,
            [Random(float.MinValue, float.MaxValue, 3)]
            float z
        ) {
            var vector = new Vector3(x, y, z);
            var expected = new Vector2(y, z);
            Assert.That(vector.ToVector2WithYZ(), Is.EqualTo(expected));
        }

        [Test]
        public void Convert_XZ_Of_Vector3_To_Vector2(
            [Random(float.MinValue, float.MaxValue, 3)]
            float x,
            [Random(float.MinValue, float.MaxValue, 3)]
            float y,
            [Random(float.MinValue, float.MaxValue, 3)]
            float z
        ) {
            var vector = new Vector3(x, y, z);
            var expected = new Vector2(x, z);
            Assert.That(vector.ToVector2WithXZ(), Is.EqualTo(expected));
        }
    }
}
