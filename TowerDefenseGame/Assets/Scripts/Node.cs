using UnityEngine;
using UnityEngine.EventSystems;

//modified on 20/18/2023 by Qusai Fannoun and Tamer Ayoub
//Switched to the new BuildManager that uses the Singleton pattern

//another modifications on 03/08/2023 by Qusai Fannoun and Tamer Ayoub. 
//Switched the TurretBlueprint to the new TurretBlueprintV2 that uses the strategy pattern
public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;

    [HideInInspector]
    public GameObject turret;
    [HideInInspector]

    public TurretBlueprintV2 turretBlueprintV2;



    [HideInInspector]
    public bool isUpgraded = false;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        //assigning the build manger to a variable to make it easy to access;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (turret != null)
        {
            BuildManager.instance.SelectNode(this);
            return;
        }

        if (!buildManager.CanBuild)
            return;

        BuildTurretV2(buildManager.GetTurretToBuildV2());
        // BuildTurret(buildManager.GetTurretToBuild());
    }


    // applying strategy pattern
    void BuildTurretV2(TurretBlueprintV2 blueprint)
    {
        if (PlayerStats.Money < blueprint.Cost)
        {
            Debug.Log("Not enough money to build that!");
            return;
        }

        PlayerStats.Money -= blueprint.Cost;

        GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

        turretBlueprintV2 = blueprint;

        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log("Turret build!");
    }

    public void UpgradeTurret()
    {
        if (PlayerStats.Money < turretBlueprintV2.UpgradeCost)
        {
            Debug.Log("Not enough money to upgrade that!");
            return;
        }

        PlayerStats.Money -= turretBlueprintV2.UpgradeCost;

        //Get rid of the old turret
        Destroy(turret);

        //Build a new one
        GameObject _turret = (GameObject)Instantiate(turretBlueprintV2.upgradedPrefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

        GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        isUpgraded = true;

        Debug.Log("Turret upgraded!");
    }

    public void SellTurret()
    {
        PlayerStats.Money += turretBlueprintV2.SellAmount;

        GameObject effect = (GameObject)Instantiate(buildManager.sellEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        Destroy(turret);
        turretBlueprintV2 = null;
    }

    // void BuildTurret(TurretBlueprint blueprint)
    // {
    //     if (PlayerStats.Money < blueprint.cost)
    //     {
    //         Debug.Log("Not enough money to build that!");
    //         return;
    //     }

    //     PlayerStats.Money -= blueprint.cost;

    //     GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
    //     turret = _turret;

    //     turretBlueprint = blueprint;

    //     GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
    //     Destroy(effect, 5f);

    //     Debug.Log("Turret build!");
    // }

    // public void UpgradeTurret()
    // {
    //     if (PlayerStats.Money < turretBlueprint.upgradeCost)
    //     {
    //         Debug.Log("Not enough money to upgrade that!");
    //         return;
    //     }

    //     PlayerStats.Money -= turretBlueprint.upgradeCost;

    //     //Get rid of the old turret
    //     Destroy(turret);

    //     //Build a new one
    //     GameObject _turret = (GameObject)Instantiate(turretBlueprint.upgradedPrefab, GetBuildPosition(), Quaternion.identity);
    //     turret = _turret;

    //     GameObject effect = (GameObject)Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
    //     Destroy(effect, 5f);

    //     isUpgraded = true;

    //     Debug.Log("Turret upgraded!");
    // }

    // public void SellTurret()
    // {
    //     PlayerStats.Money += turretBlueprint.GetSellAmount();

    //     GameObject effect = (GameObject)Instantiate(buildManager.sellEffect, GetBuildPosition(), Quaternion.identity);
    //     Destroy(effect, 5f);

    //     Destroy(turret);
    //     turretBlueprint = null;
    // }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        if (buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }
        else
        {
            rend.material.color = notEnoughMoneyColor;
        }

    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

}
