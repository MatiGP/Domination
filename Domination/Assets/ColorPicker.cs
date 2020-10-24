using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    [SerializeField] Image colorDisplayer;
    [SerializeField] Slider redSlider;
    [SerializeField] Slider greenSlider;
    [SerializeField] Slider blueSlider;

    private void Awake()
    {
        redSlider.value = colorDisplayer.color.r;
        greenSlider.value = colorDisplayer.color.g;
        blueSlider.value = colorDisplayer.color.b;
    }


    public void ModifyRedColorValue(float newColorValue)
    {
        colorDisplayer.color = new Color(newColorValue, colorDisplayer.color.g, colorDisplayer.color.b);
    }

    public void ModifyGreenColorValue(float newColorValue)
    {
        colorDisplayer.color = new Color(colorDisplayer.color.r, newColorValue, colorDisplayer.color.b);
    }

    public void ModifyBlueColorValue(float newColorValue)
    {
        colorDisplayer.color = new Color(colorDisplayer.color.r, colorDisplayer.color.g, newColorValue);
    }


}
