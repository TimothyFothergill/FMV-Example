// Attach this script to the UI GameObject.
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NavigationButtons : MonoBehaviour
{
    // Variables for the next and previous scenes.
    public string forwardScene;
    public string backScene;

    // This variable is for the VideoPlayer that's on the Camera.
    public VideoPlayer vp;

    public void ForwardPress()
    {
        // This While loop checks if the video is playing. If so, it returns nothing, meaning the button can't be clicked.   
        while (vp.isPlaying)
        {
            return;
        }

        // LoadScene has 1 required argument - The name of the scene you wish to load.
        SceneManager.LoadScene(forwardScene, LoadSceneMode.Single);
    }

    public void BackPress()
    {
        while (vp.isPlaying)
        {
            return;
        }

        // LoadScene has 1 optional argument - LoadSceneMode. Single frees up resources as needs be.
        SceneManager.LoadScene(backScene, LoadSceneMode.Single);
    }
}
