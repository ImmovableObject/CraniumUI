using System.Collections;
using UnityEngine;

public class HUDSuperPowerBar : MonoBehaviour {

    //Add the HUD Manager to Script
    HUDManager HM;
    public GameObject hudManager;

    //Speed that the script will check for changes; Lower number for faster rate
    private float refreshRate = 0.1f;

    //Reference the ParticleSystem of the object
    ParticleSystem ps;

    //Function that runs once when the Object is enabled
    void Awake ()
    {
        //Set up some shortcuts for the ParticleSystem and hudManager
        HM = hudManager.GetComponent<HUDManager>();
        ps = GetComponent<ParticleSystem>();

        //Access the main module of ps. This is forgotten after Awake is done executing.
        var psMain = ps.main;

        //Make sure the start size and speed of spawned particles is 0.0f at the start
        psMain.startSize = 0.0f;
        psMain.startSpeed = 0.0f;
       
        //Start checking for changes
        StartCoroutine(Refresh());
    }

    //A Function that is set to loop
    IEnumerator Refresh()
    {
        //Wait for time to pass in seconds
        yield return new WaitForSeconds(refreshRate);

        //Access the main module of ps. This is forgotten after each loop of Refresh
        var psMain = ps.main;

        //Is HM.SuperPowerEquipped is equal to or greater then 1
        if (HM.SuperPowerEquipped >= 1)
        {
            //Run SetStage funtion to determine size and speed
            psMain.startSize = 1.0f;
            SetStage();
        }
        //Otherwise make sure the speed and size are 0.0f.
        else
        {
            psMain.startSize = 0.0f;
            psMain.startSpeed = 0.0f;
        }

        //Restart the loop
        StartCoroutine(Refresh());
    }

    //Set the size and speed of particles based the value of HM.SuperPowerPercentage
    void SetStage()
	{	
		var psMain = ps.main;

		switch(HM.SuperPowerPercentage){	
		case 0:
                psMain.startSize = 0.0f;
                psMain.startSpeed = 0.0f;
                return;
		case 5:
                psMain.startSize = 1.0f;
                psMain.startSpeed = 0.13f;
                return;
		case 10:psMain.startSpeed = 0.26f;return;
		case 15:psMain.startSpeed = 0.39f;return;	
		case 20:psMain.startSpeed = 0.52f;return;
		case 25:psMain.startSpeed = 0.65f;return;			
		case 30:psMain.startSpeed = 0.78f;return;			
		case 35:psMain.startSpeed = 0.91f;return;			
		case 40:psMain.startSpeed = 1.04f;return;			
		case 45:psMain.startSpeed = 1.17f;return;
		case 50:psMain.startSpeed = 1.3f;return;			
		case 55:psMain.startSpeed = 1.43f;return;
		case 60:psMain.startSpeed = 1.56f;return;
		case 65:psMain.startSpeed = 1.69f;return;
		case 70:psMain.startSpeed = 1.82f;return;
		case 75:psMain.startSpeed = 1.95f;return;
		case 80:psMain.startSpeed = 2.08f;return;
		case 85:psMain.startSpeed = 2.21f;return;
		case 90:psMain.startSpeed = 2.34f;return;
		case 95:psMain.startSpeed = 2.47f;return;
		case 100:psMain.startSpeed = 2.6f;return;
		}
	}
}