//Modified on 03/08/2023 by Qusai Fannoun and Tamer Ayoub. 
//Switched the TurretBlueprint to the new TurretBlueprintV2 that uses the strategy pattern
using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprintV2 standardTurret = new StandardTurret();
    public TurretBlueprintV2 missileLauncher = new MissileLauncher();
    public TurretBlueprintV2 laserBeamer = new LaserBeamer();


    BuildManager buildManager;

    void Start()
    {
        buildManager = GameObject.FindObjectOfType<BuildManager>();

    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuildV2(standardTurret);
    }

    public void SelectMissileLauncher()
    {
        Debug.Log("Missile Launcher Selected");
        buildManager.SelectTurretToBuildV2(missileLauncher);
    }

    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuildV2(laserBeamer);
    }
}
