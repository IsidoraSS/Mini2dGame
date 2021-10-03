using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void healthNaMax(int health)
    {
        slider.maxValue = health;
        namestiHealth(health);
    }

    public void namestiHealth(int health)
    {
        slider.value = health;
    }

}
