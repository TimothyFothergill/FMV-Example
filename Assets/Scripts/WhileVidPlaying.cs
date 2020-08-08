using UnityEngine;
using UnityEngine.Video;

public class WhileVidPlaying : MonoBehaviour
{

    private VideoPlayer vc;

    private void Start()
    {
        vc = GameObject.Find("Main Camera").GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vc.isPlaying)
        {
            this.GetComponent<Canvas>().enabled = false;
        } else
        {
            this.GetComponent<Canvas>().enabled = true;
        }
        
    }
}
