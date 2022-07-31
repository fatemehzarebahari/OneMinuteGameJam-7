using UnityEngine;

public class lineDetected : MonoBehaviour
{
    public bool detected = false;
    public void setDetected(bool value)
    {
        detected = value;
    }
    public bool getDetected()
    {
        return detected;
    }
}
