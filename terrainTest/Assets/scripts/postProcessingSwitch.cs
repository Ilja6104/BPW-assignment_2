using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class postProcessingSwitch : MonoBehaviour {

    PostProcessVolume volume;
   
    Vignette vignette;
    ChromaticAberration chromaticAberration;
    public static ColorGrading colorGrading;
    public static float transitionSpeed = 1.5f;
    static float t = 0.0f;
    static float u = 0.0f;
    public static bool endLevelLerp = false;
    public static bool startLevelLerp = true;


    void Start()
    {
        vignette = ScriptableObject.CreateInstance<Vignette>();
        vignette.enabled.Override(true);

        chromaticAberration = ScriptableObject.CreateInstance<ChromaticAberration>();
        chromaticAberration.enabled.Override(true);

        colorGrading = ScriptableObject.CreateInstance<ColorGrading>();
        colorGrading.enabled.Override(true);

        volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, vignette, chromaticAberration, colorGrading);
        

    }

    void Update()
    {
      if(characterHealth.currentHealth <= 5)
        {
            vignette.intensity.Override(0.3f);
            chromaticAberration.intensity.Override(0.8f);

        }
      else if (characterHealth.currentHealth <= 8)
        {
            vignette.intensity.Override(0.6f);
            chromaticAberration.intensity.Override(1f);
        }
      else
        {
            vignette.intensity.Override(0f);
            chromaticAberration.intensity.Override(0f);
        }

        
        if (startLevelLerp == true)
        {
            colorGrading.postExposure.Override(Mathf.Lerp(0f, 7f, u) - 7);
            u += transitionSpeed * Time.deltaTime;
            if (u >= 6)
            {
                
                startLevelLerp = false;
                u = 0.0f;
                
            }
        }


        if (endLevelLerp == true)
        {
            colorGrading.postExposure.Override(Mathf.Lerp(0f, 7f, t) * -1) ;
            t += transitionSpeed * Time.deltaTime;
            if(t >= 6)
            {
                
                endLevelLerp = false;
                t = 0.0f;
                startLevelLerp = true;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

    }




    public static void nextlevel()
    {
        

    }
    
}
