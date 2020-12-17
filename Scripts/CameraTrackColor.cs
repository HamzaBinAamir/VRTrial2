using UnityEngine;
namespace HBAHome
{
	public class CameraTrackColor : MonoBehaviour
	{
		//public variables
		public Light colorLight;
		public Color colorRight;
		public Color colorLeft;

		//private variables
		private float location;
		void Update()
		{
			location = ((transform.rotation.y / 0.707f) / 2) + 0.5f;
			colorLight.color = Color.Lerp(colorLeft, colorRight, location);
		}
	}
}