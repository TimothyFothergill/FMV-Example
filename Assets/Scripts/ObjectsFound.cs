using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class ObjectsFound : MonoBehaviour
{

    // Private variables are only used in the file they're declared in. 
    // Public variables are accessible outside of the file they're declared in.
    // Public Variables are editable in the Inspector, Private Variables are not...
    // Private Variables CAN be edited in the Inspector IF you put [SerializeField] in front of it.
    // We keep the text box private, so other scripts can't manipulate it... But...
    // We make the objectsFound integer public, so other scripts can add or remove items found.

    [SerializeField] private Text objectsFoundText;
    [SerializeField] private Text descriptorText;
    public int objectsFound = 0;

    void Update()
    {
        // Simply updates the Objects Found counter at the top.
        objectsFoundText.text = "Objects Found " + objectsFound.ToString();
    }

    // This function just adds 1 to the counter.
    public void AddObjectFound()
    {
        objectsFound += 1;
    }

    public void ClearDescription()
    {
        // Coroutines are used when you want to run some code that runs in the background. The code you call StartCoroutine from continues. Check the Console to watch when the messages appear.
        print("Before Coroutine");
        StartCoroutine("countdown");
        print("After Coroutine");
    }

    // IEnumerator comes from "using System.Collections;". This runs at the same time as the rest of the code, but in a different "thread".
    IEnumerator countdown()
    {
        print("In Coroutine");
        // "yield return new WaitForSeconds(time)" will make the coroutine (IEnumerator) wait until the time has passed.
        yield return new WaitForSeconds(5.0f);
        print("I waited 5 seconds... Resetting Description Text.");
        descriptorText.text = "";
        StopAllCoroutines();
    }
}