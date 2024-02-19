using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncher;
	public TurretBlueprint laserBeamer;
	public TurretBlueprint bumpTurret;
	public TurretBlueprint tankTurret;
	public TurretBlueprint energyTurret;

	BuildManager buildManager;

	void Start ()
	{
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTurret ()
	{
		Debug.Log("Standard Turret Selected");
		buildManager.SelectTurretToBuild(standardTurret);
	}

	public void SelectMissileLauncher()
	{
		Debug.Log("Missile Launcher Selected");
		buildManager.SelectTurretToBuild(missileLauncher);
	}

	public void SelectLaserBeamer()
	{
		Debug.Log("Laser Beamer Selected");
		buildManager.SelectTurretToBuild(laserBeamer);
	}

	public void SelectBumpTurret()
	{
		Debug.Log("Bump Turret Selected");
		buildManager.SelectTurretToBuild(bumpTurret);
	}

	public void SelectTankTurret()
	{
		Debug.Log("Tank Turret Selected");
		buildManager.SelectTurretToBuild(tankTurret);
	}

	public void SelectEnergyTurret()
	{
		Debug.Log("Energy Turret Selected");
		buildManager.SelectTurretToBuild(energyTurret);
	}


}
