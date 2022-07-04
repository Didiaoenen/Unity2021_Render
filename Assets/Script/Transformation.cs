using UnityEngine;

namespace Test
{
    public abstract class Transformation : MonoBehaviour
    {
        public abstract Matrix4x4 Matrix { get; }
    }
}
