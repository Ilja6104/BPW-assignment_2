using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class postProcessingSwitch : MonoBehaviour {

    PostProcessVolume m_Volume;
    Vignette m_Vignette;
    ChromaticAberration m_chromaticAberration;

    void Start()
    {
        m_Vignette = ScriptableObject.CreateInstance<Vignette>();
        m_Vignette.enabled.Override(true);
        m_chromaticAberration = ScriptableObject.CreateInstance<ChromaticAberration>();
        m_chromaticAberration.enabled.Override(true);

        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Vignette, m_chromaticAberration);
    }

    void Update()
    {
      if(characterHealth.currentHealth <= 5)
        {
            m_Vignette.intensity.Override(0.3f);
            m_chromaticAberration.intensity.Override(0.8f);

        }
      else if (characterHealth.currentHealth <= 8)
        {
            m_Vignette.intensity.Override(0.6f);
            m_chromaticAberration.intensity.Override(1f);
        }
      else
        {
            m_Vignette.intensity.Override(0f);
            m_chromaticAberration.intensity.Override(0f);
        }
    }

 
}
