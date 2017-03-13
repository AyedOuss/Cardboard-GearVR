using UnityEngine;
using UnityEditor;
public class VRBuildSettings
{
    [MenuItem("VR Build Settings/Build GearVR")]
    static void BuildGearVRSettings()
    {
        PlayerSettings.virtualRealitySupported = true;
        Cardboard cardboard = (Cardboard)GameObject.FindGameObjectWithTag("Player").GetComponent<Cardboard>();
        CardboardHead cardboardHead = cardboard.gameObject.transform.GetChild(0).gameObject.GetComponent<CardboardHead>();
        cardboard.VRModeEnabled = false;
        cardboardHead.trackPosition = false;
        cardboardHead.trackRotation = false;
        EditorUtility.SetDirty(cardboard);
        EditorUtility.SetDirty(cardboardHead);
    }

    [MenuItem("VR Build Settings/Build Cardboard")]
    static void BuildCardboardSettings()
    {
        PlayerSettings.virtualRealitySupported = false;
        Cardboard cardboard = (Cardboard)GameObject.FindGameObjectWithTag("Player").GetComponent<Cardboard>();
        CardboardHead cardboardHead = cardboard.gameObject.transform.GetChild(0).gameObject.GetComponent<CardboardHead>();
        cardboard.VRModeEnabled = true;
        cardboardHead.trackPosition = true;
        cardboardHead.trackRotation = true;
        EditorUtility.SetDirty(cardboard);
        EditorUtility.SetDirty(cardboardHead);
    }

}
