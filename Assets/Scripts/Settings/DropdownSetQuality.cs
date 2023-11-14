using UnityEngine;

public class DropdownSetQuality : MonoBehaviour
{
    public void SetQuality(int level)
    {
        QualitySettings.SetQualityLevel(level);
    }
}
