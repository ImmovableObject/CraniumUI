using System.Collections;
using UnityEngine;

public class HUDSuperPowerMeter : MonoBehaviour {

    HUDManager HM;
    public GameObject hudManager;
    private float refreshRate = 0.1f;

    void Awake()
    {
        HM = hudManager.GetComponent<HUDManager>();
        StartCoroutine(Refresh());
    }

    IEnumerator Refresh()
    {
        yield return new WaitForSeconds(refreshRate);

        if (HM.SuperPowerEquipped >= 1) {GetComponent<Renderer>().enabled = true;}
        else {GetComponent<Renderer>().enabled = false; }

        StartCoroutine(Refresh());
    } 
}