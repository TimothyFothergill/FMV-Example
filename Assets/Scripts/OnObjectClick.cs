using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class OnObjectClick : MonoBehaviour
{
    // SerializeField allows us to keep an object private, so only this script can access the variable...
    // BUT makes it available to drag and drop GameObjects to via the inspector (the GUI of Unity).

    private ObjectsFound of;
    [SerializeField] private Text descriptor;
    public GameObject thisObject;
    public ClickableObject cbo;
    private VideoPlayer vc;
    Image imageSrc;

    public void Start()
    {
        // These variables are declared in the class (public VideoPlayer vc; for instance).
        // When the script is available, Start() launches and will find the Main Camera GameObject.
        // The Main Camera GameObject has a Component which we target with the GetComponent function.
        // We then just have to point at the correct comment which is VideoPlayer.
        vc = GameObject.Find("Main Camera").GetComponent<VideoPlayer>();
        of = GameObject.Find("UI").transform.Find("Text").GetComponent<ObjectsFound>();
        imageSrc = thisObject.GetComponent<Image>();
    }

    // Every frame, this script quickly looks and says "is Video Player currently playing? Yeah? Cool, disable the clickable object. If not, re-enable it".
    public void Update()
    {
        if (vc.isPlaying && imageSrc.enabled == true)
        {
            imageSrc.enabled = false;
        }
        else if (!vc.isPlaying)
        {
            imageSrc.enabled = true;
        }

    }

    public void OnMouseOver()
    {
        // This just finds where the video player component is. In this case, it's attached to the camera.
        // This public function we attach to the GameObject's 
        print("Click found!");
            if (cbo.removeOnClick)
            {

                while (vc.isPlaying)
                {
                    return;
                }
                    of.AddObjectFound();
                    descriptor.text = cbo.description;
                    of.ClearDescription();
                    Destroy(thisObject);
                }
                else // If ClickableObject is NOT to be removed On Click
                {
                    while (vc.isPlaying)
                    {
                        return;
                    }
                descriptor.text = cbo.description;
                of.ClearDescription();
                }
    }
}