using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

    public GameObject videoObject;

	public void ToogleVideo()
    {
        videoObject.SetActive(!videoObject.activeInHierarchy);
    }

    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
