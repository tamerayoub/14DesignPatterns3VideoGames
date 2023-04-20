using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthModel : HealthType
{
    public float HealthPoints = 100;
    public TextMeshProUGUI HealthAmountText;

    public Slider HealthBar;
}
