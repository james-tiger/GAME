using UnityEngine;

public class HideFruit : MonoBehaviour
{
    public GameObject objectToShow;
    public float hideDelay = 0.0f;
    public float showDelay = 5.0f;

    void Start()
    {
        HideObject();

        Invoke("ShowObject", showDelay);
    }

    void HideObject()
    {
        objectToShow.SetActive(false);
    }

    void ShowObject()
    {
        objectToShow.SetActive(true);
    }
}
