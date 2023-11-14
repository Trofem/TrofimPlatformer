using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    [SerializeField] private Color Purple = Color.white;
    [SerializeField] private Color Yellow = Color.white;

    [SerializeField] private GameObject PS_UI;
    [SerializeField] private GameObject XB_UI;
    [SerializeField] private Image image;

    // Start is called before the first frame update
    void Awake()
    {
        //image = gameObject.GetComponent<Image>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (DropdownController.Controller == "PS")
        {
            image.color = Purple;
            XB_UI.SetActive(false);
            PS_UI.SetActive(true);
        }
        else if (DropdownController.Controller == "XBOX")
        {
            image.color = Yellow;
            PS_UI.SetActive(false);
            XB_UI.SetActive(true);
        }
        else if (DropdownController.Controller == "none")
        {
            image.color = Purple;
            XB_UI.SetActive(false);
            PS_UI.SetActive(false);
        }

    }
    
}
