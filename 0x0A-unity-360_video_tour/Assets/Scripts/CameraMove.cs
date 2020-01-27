using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Animator fade;
    public Transform cameraRig;
    public Transform lR;
    public Transform cA;
    public Transform cU;
    public Transform mZ;
    public GameObject lrUI;
    public GameObject caUI;
    public GameObject cuUI;
    public GameObject mzUI;
    public GameObject lrInfo1;
    public GameObject lrInfo2;
    public GameObject caInfo1;
    public GameObject cuInfo1;
    public GameObject mzInfo1;
    public GameObject mzInfo2;
    private string targetRoom;
    private Dictionary<string, Transform> camDict = new Dictionary<string, Transform>();
    private Dictionary<string, GameObject> uiDict = new Dictionary<string, GameObject>();
    
    //Start runs before the first frame renders
    void Start()
    {
        camDict.Add("LR", lR);
        camDict.Add("CA", cA);
        camDict.Add("CU", cU);
        camDict.Add("MZ", mZ);
        uiDict.Add("LR", lrUI);
        uiDict.Add("CA", caUI);
        uiDict.Add("CU", cuUI);
        uiDict.Add("MZ", mzUI);
        uiDict.Add("1", lrInfo1);
        uiDict.Add("2", lrInfo2);
        uiDict.Add("3", caInfo1);
        uiDict.Add("4", cuInfo1);
        uiDict.Add("5", mzInfo1);
        uiDict.Add("6", mzInfo2);
    }

    ///<summary>Triggers camera fadeout.</summary>
    public void FadeTo(string room)
    {
        targetRoom = room;
        fade.SetTrigger("FadeOut");
    }

    ///<summary>Triggers room reset and camera fadein.</summary>
    public void OnFadeComplete()
    {
        RoomReset();
        cameraRig.position = camDict[targetRoom].position;
        fade.SetTrigger("FadeIn");
    }

    ///<summary>Resets videospheres and interactive objects.</summary>
    void RoomReset()
    {
        foreach (Transform room in camDict.Values)
        {
            room.gameObject.SetActive(false);
        }
        foreach (GameObject ui in uiDict.Values)
        {
            ui.SetActive(false);
        }

        camDict[targetRoom].gameObject.SetActive(true);
        uiDict[targetRoom].SetActive(true);
    }
}
