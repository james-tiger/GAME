using UnityEngine;

public class PlayButtonHandler : MonoBehaviour
{
    public Transform[] movingObjects;

    public void MoveObjects()
    {
        foreach (var obj in movingObjects)
        {
            obj.GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }
}
