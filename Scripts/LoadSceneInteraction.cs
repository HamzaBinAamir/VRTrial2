using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneInteraction : MonoBehaviour
{
	public string SceneToLoad;
    public void Load()
	{
		SceneManager.LoadSceneAsync(SceneToLoad);
	}
}
