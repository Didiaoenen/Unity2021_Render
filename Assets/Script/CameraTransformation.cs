using UnityEngine;

namespace Test
{
    public class CameraTransformation : Transformation
    {
        public enum CameraType
        {
            O,
            P,
        }

        public CameraType cameraType = CameraType.O;

        public float focalLength = 2f;

        public override Matrix4x4 Matrix
        {
            get
            {
                Matrix4x4 matrix = new Matrix4x4();
                matrix.SetRow(0, new Vector4(focalLength, 0f, 0f, 0f));
                matrix.SetRow(1, new Vector4(0f, focalLength, 0f, 0f));
                matrix.SetRow(2, new Vector4(0f, 0f, 0f, 0f));
                if (cameraType == CameraType.O)
                {
                    matrix.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
                }
                else
                {
                    matrix.SetRow(3, new Vector4(0f, 0f, 1f, 0f));
                }
                return matrix;
            }
        }
    }
}
