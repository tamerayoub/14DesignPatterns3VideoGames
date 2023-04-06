using UnityEngine;
using UnityEngine.UI;


//Modified on 03/08/2023 by Qusai Fannoun and Tamer Ayoub. 
//Switched the TurretBlueprint to the new TurretBlueprintV2 that uses the strategy pattern
public class NodeUI : MonoBehaviour {

	public GameObject ui;

	public Text upgradeCost;
	public Button upgradeButton;

	public Text sellAmount;

	private Node target;

	public void SetTarget (Node _target)
	{
		target = _target;

		transform.position = target.GetBuildPosition();

		if (!target.isUpgraded)
		{
			upgradeCost.text = "$" + target.turretBlueprintV2.UpgradeCost;
			upgradeButton.interactable = true;
		} else
		{
			upgradeCost.text = "DONE";
			upgradeButton.interactable = false;
		}

		sellAmount.text = "$" + target.turretBlueprintV2.SellAmount;

		ui.SetActive(true);
	}

	public void Hide ()
	{
		ui.SetActive(false);
	}

	public void Upgrade ()
	{
		target.UpgradeTurret();
		BuildManager.instance.DeselectNode();
	}

	public void Sell ()
	{
		target.SellTurret();
		BuildManager.instance.DeselectNode();
	}

}
