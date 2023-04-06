using UnityEngine;

//modified on 20/18/2023
// Inheriting from the singleton class to create and unique instance

//another modifications on 03/08/2023 by Qusai Fannoun and Tamer Ayoub. 
//Switched the TurretBlueprint to the new TurretBlueprintV2 that uses the strategy pattern
public class BuildManager : Singleton<BuildManager>
{
    public GameObject buildEffect;
    public GameObject sellEffect;


    // This is the Super Class TurretBlueprintV2
    private TurretBlueprintV2 turretToBuildV2;
    private Node selectedNode;

    public NodeUI nodeUI;

    public bool CanBuild { get { return turretToBuildV2 != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuildV2.Cost; } }

    public void SelectNode(Node node)
    {
        if (selectedNode == node)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        turretToBuildV2 = null;
        nodeUI.SetTarget(node);
    }

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

    public void SelectTurretToBuildV2(TurretBlueprintV2 turret)
    {
        turretToBuildV2 = turret;
        DeselectNode();
    }

    public TurretBlueprintV2 GetTurretToBuildV2()
    {
        return turretToBuildV2;
    }

}
