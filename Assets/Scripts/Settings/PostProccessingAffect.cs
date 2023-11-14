using UnityEngine;
using UnityEngine.UI;

public class PostProccessingAffect : MonoBehaviour
{
    public static float affect = 0.5f;
    [SerializeField] private Text postProcessText;
    void Start()
    {
    }
    public void ScrollBarPostProcessData(float val)
    {
        affect = val;
        affect = Mathf.Round(affect * 100.0f) * 0.01f;
        postProcessText.text = "Shader Power = " + affect + ".";
    }
}
