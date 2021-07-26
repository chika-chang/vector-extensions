using UnityEngine;

namespace Chika.Extensions {
    public static class VectorExtensions {
        public static Vector2 ChangeX(this Vector2 vector, float value) => new Vector2(value, vector.y);
        public static Vector2 ChangeY(this Vector2 vector, float value) => new Vector2(vector.x, value);

        public static Vector3 ChangeX(this Vector3 vector, float value) => new Vector3(value, vector.y, vector.z);
        public static Vector3 ChangeY(this Vector3 vector, float value) => new Vector3(vector.x, value, vector.z);
        public static Vector3 ChangeZ(this Vector3 vector, float value) => new Vector3(vector.x, vector.y, value);

        public static Vector2 ToVector2(this Vector3 vector) => new Vector2(vector.x, vector.y);
        public static Vector2 ToVector2WithYZ(this Vector3 vector) => new Vector2(vector.y, vector.z);
        public static Vector2 ToVector2WithXZ(this Vector3 vector) => new Vector2(vector.x, vector.z);

        public static Vector3 ToVector3(this Vector2 vector) => new Vector3(vector.x, vector.y, 0);
        public static Vector3 ToVector3WithYZ(this Vector2 vector) => new Vector3(0, vector.x, vector.y);
        public static Vector3 ToVector3WithXZ(this Vector2 vector) => new Vector3(vector.x, 0, vector.y);
    }
}
