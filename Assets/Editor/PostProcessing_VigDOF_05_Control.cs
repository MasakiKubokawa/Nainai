using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEditor;

namespace ClusterCreatorEditorScript
{
    public class PostProcessing_VigDOF_05_Control : MonoBehaviour
    {
        // Post Process Volume がついているGameObject
        [SerializeField] PostProcessVolume postProcessVolume;

        // Start is called before the first frame update
        void OnEnable()
        {
            Debug.Log("hit");
            Vignette vig;
            postProcessVolume.profile.TryGetSettings(out vig);
            vig.enabled.value = true;
            var colorParameter = new UnityEngine.Rendering.PostProcessing.ColorParameter();
            colorParameter.value = new Color(0.5f, 0.5f, 0.5f, 1.0f);
            vig.color.Override(colorParameter);
            vig.intensity.value = 1.0f;

            DepthOfField dof;
            postProcessVolume.profile.TryGetSettings(out dof);
            dof.enabled.value = true;
            dof.focalLength.value = 100.0f;
        }
    }
}
