using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State //: MonoBehaviour
{
   public abstract void BuyTurret();
   public abstract void SellTurret();
   public abstract void UpgradeTurret();
}
