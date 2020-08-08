using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "GameData/ClickableObject", order = 1)]
public class ClickableObject : ScriptableObject
{
    // This is a ScriptableObject, allowing you to make different objects in the context menu (Right click in the Project view).
    // The following are variables we will care about

    public string itemName;
    public Sprite itemImage;
    public string description;
    public bool removeOnClick;


    // You can use another script to handle each object type. See Script: OnObjectClick
}
