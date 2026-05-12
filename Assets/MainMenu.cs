using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	public void PlayGme()
	{
		SceneManager.LoadSceneAsync(1);
	}
	
}
