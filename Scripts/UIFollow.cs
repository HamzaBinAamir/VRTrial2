using UnityEngine; //This is the only library we really need to worry about

namespace HBAHome
{
	public class UIFollow : MonoBehaviour
	{
		//public enumerations
		public enum Dimension { x, y, z, xb, yb, zb}
		//public variables
		[Range(0.001f, 1f)]
		public float AlignmentRate; 
		public Transform AlignmentCameraObj;
		public Dimension lookDimension;

		void Update()
		{
			//Modify the position of the object to align with the camera a little more every frame
			transform.position = Vector3.Lerp(transform.position, AlignmentCameraObj.position, AlignmentRate);
			// "Look at" the camera
			if (lookDimension == Dimension.x) {
				transform.LookAt(AlignmentCameraObj.parent.transform, Vector3.forward);
			}
			if (lookDimension == Dimension.xb)
			{
				transform.LookAt(AlignmentCameraObj.parent.transform, Vector3.back);
			}
			if (lookDimension == Dimension.y)
			{
				transform.LookAt(AlignmentCameraObj.parent.transform, Vector3.up);
			}
			if (lookDimension == Dimension.yb)
			{
				transform.LookAt(AlignmentCameraObj.parent.transform, Vector3.down);
			}
			if (lookDimension == Dimension.z)
			{
				transform.LookAt(AlignmentCameraObj.parent.transform, Vector3.right);
			}
			if (lookDimension == Dimension.zb)
			{
				transform.LookAt(AlignmentCameraObj.parent.transform, Vector3.left);
			}
		}
	}
}