using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace HBAHome {
	public class UIAlert : MonoBehaviour
	{
		//public variables
		public static float Damage;
		public float DamageThreshold;
		public string LoseSceneName;
		public bool Testing = false;

		//private variables
		private Image img;
		private bool ChangeRequested;

		void Awake()
		{
			img = gameObject.GetComponent<Image>();
			ChangeRequested = false;
		}

		void Update()
		{
			if (Damage >= DamageThreshold && !ChangeRequested)
			{
				SceneManager.LoadSceneAsync(LoseSceneName);
				ChangeRequested = true;
			}
			img.color = new Color(img.color.r, img.color.g, img.color.b, Damage/DamageThreshold);
			if (Testing)
			{
				TakeDamage(0.01f);
			}
		}

		public void TakeDamage(float dmg)
		{
			Damage += dmg;
		}
	}
}