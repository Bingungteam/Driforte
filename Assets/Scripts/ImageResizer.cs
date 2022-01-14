using UnityEngine;

public class ImageResizer : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(1.2f, 1.2f, 1), "delay", 0.2f, "time", 1.0f));
    }

    public void OnDisable()
    {
        iTween.Stop();
        Vector3 myVector3 = new Vector3(1, 1, 1);
        gameObject.transform.localScale = myVector3;
    }
}
