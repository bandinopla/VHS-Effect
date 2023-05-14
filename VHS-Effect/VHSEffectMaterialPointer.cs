using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName = "VHSEffectMaterialPointer", menuName = "VHS Effect/VHSEffectMaterialPointer")]
public class VHSEffectMaterialPointer : UnityEngine.ScriptableObject
{
    //---Your Materials---
    public Material VHSEffectMaterial;

    //---Accessing the data from the Pass---
    static VHSEffectMaterialPointer _instance;

    public static VHSEffectMaterialPointer Instance
    {
        get
        {
            if (_instance != null) return _instance;
            // TODO check if application is quitting
            // and avoid loading if that is the case

            _instance = Resources.Load("VHSEffectMaterialPointer") as VHSEffectMaterialPointer;
            return _instance;
        }
    }
}