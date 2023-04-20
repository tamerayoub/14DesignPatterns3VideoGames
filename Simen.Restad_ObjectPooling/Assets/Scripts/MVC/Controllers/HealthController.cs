using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : HealthType
{
    double timePassed;


    public void OnDamageZoneEnter()
    {
        UpdateHealthGUI(-10, 0.1f);
    }


    public void OnHealthZoneEnter()
    {
        UpdateHealthGUI(5, 0.5f);
    }


    public void UpdateHealthGUI(float HealAmount, float DelayTime)
    {
        app.model.HealthBar.maxValue = 100;
        timePassed += Time.deltaTime;
        if (timePassed >= DelayTime)
        {
            app.model.HealthPoints += HealAmount;
            app.model.HealthBar.value = app.model.HealthPoints;
            timePassed = 0;
            app.model.HealthAmountText.text = app.model.HealthPoints.ToString() + "/100";
        }

        if (app.model.HealthPoints >= 99) 
        {
            app.model.HealthPoints = 100;
        }
    }
}
