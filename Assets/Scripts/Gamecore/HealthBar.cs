using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image Straw;
    // Start is called before the first frame update
    void Start()
    {
        Straw = GetComponent<Image>();
        Straw.fillAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Straw.fillAmount = (float)ItemCollector.strawberries / (float)ItemCollector.need;
    }
}
