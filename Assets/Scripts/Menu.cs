using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

}
