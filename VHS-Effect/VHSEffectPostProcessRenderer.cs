using UnityEngine.Rendering.Universal;

[System.Serializable]
public class VHSEffectPostProcessRenderer : ScriptableRendererFeature
{
    VHSEffectPostProcessPass pass;

    public override void Create()
    {
        pass = new VHSEffectPostProcessPass();
    }

    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        renderer.EnqueuePass(pass);
    }
}