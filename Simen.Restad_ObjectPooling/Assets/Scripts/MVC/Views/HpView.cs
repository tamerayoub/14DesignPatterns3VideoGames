using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpView : HealthType
{
    void OnTriggerStay2D() { app.controller.OnHealthZoneEnter(); }
}
