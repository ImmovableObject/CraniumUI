using System.Collections;
using UnityEngine;

public class HUDUIHide : MonoBehaviour
{
    HUDManager HM;
    public GameObject hudManager;
    private float refreshRate = 0.1f;
    Renderer r;
    public bool BossItem;

    void Start()
    {
        r = GetComponent<Renderer>();
        HM = hudManager.GetComponent<HUDManager>();
        StartCoroutine(Refresh());
    }

    IEnumerator Refresh()
    {
        yield return new WaitForSeconds(refreshRate);
        CheckActive();
    }

    void CheckActive(){
        if(BossItem && !HM.BossActive){r.enabled = false;}
        if(HM.ActiveMenu >= 1){r.enabled = false;}
		if(HM.ActiveMenu <= 0){r.enabled = true;}
        StartCoroutine(Refresh());
    }
}