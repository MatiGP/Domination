using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LocalScreen : MonoBehaviour
{
    [SerializeField] Slider turnDurationSlider;
    [SerializeField] TextMeshProUGUI turnDurationText;

    private void Awake()
    {
        turnDurationText.text = turnDurationSlider.value.ToString() + " sekund";
    }

    public void SetDuraitonText(float duration)
    {
        if (duration == 121)
        {
            turnDurationText.text = "Bez limitu";
        }
        else
        {
            turnDurationText.text = duration.ToString() + " sekund";
        }
       
    }


}
