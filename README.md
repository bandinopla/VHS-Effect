# Post Process VHS Filter for Unity URP
Done following the tutorials made by **[Ben Cloward](https://www.youtube.com/@BenCloward)** and another tutorial made by **[Febucci](https://www.febucci.com/)**

The series watched to understand the shader is:
1. https://www.youtube.com/watch?v=_gO5Q-wFL1U
2. https://www.youtube.com/watch?v=Wyz1lDBrDzE
3. https://www.youtube.com/watch?v=k5mzB9PSg4o

The tutorial to do the custom post processing volume: https://www.febucci.com/2022/05/custom-post-processing-in-urp/

The result ends up looking like this:

<img src="preview.gif"/>

## How to use
Copy and paste the `VHS-Effect` folder into your Assets folder, then:

1. In your Resources folder hit : `Create > VHS Effect > VHSEffectMaterialPointer`
2. In the material slot of the created scriptable object, place the `VHS-Effect/VHSEffect.mat` material
3. Add the `VHSEffectPostProcessRenderer` to your render features.
4. Add the `VHSEffectComponent` override to your post-processing volume
5. Enjoy!

## Made with
* Unity 2021.1.12f1
* URP Version 11.0.0 


