using UnityEngine;

public class LogoAnimation : MonoBehaviour
{
    public void Start()
    {
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(1.2f, 1.2f, 1), "delay", 0.2f, "time", 1.0f, "loopType", iTween.LoopType.pingPong));    
    }
}
