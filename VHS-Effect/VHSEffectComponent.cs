using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Serializable ]
public class VHSEffectComponent : VolumeComponent, IPostProcessComponent
{
    // Define a serialized field for the MaterialPropertyBlock
    [SerializeField]
    private MaterialPropertyBlock materialPropertyBlock;

    // Define a property to access the MaterialPropertyBlock
    public MaterialPropertyBlock MaterialPropertyBlock => materialPropertyBlock;

    public ClampedFloatParameter intensity          = new ClampedFloatParameter(value: 0, min: 0, max: 1, overrideState: true); 
    public NoInterpColorParameter noiseColor        = new NoInterpColorParameter(Color.white); 
    public ClampedFloatParameter scanlinesHeight    = new ClampedFloatParameter(value: 0, min: 0, max: 3, overrideState: true);
    
     
    public bool IsActive() => intensity.value > 0;
     
    public bool IsTileCompatible() => true;
}