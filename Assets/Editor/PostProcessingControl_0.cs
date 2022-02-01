using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingControl_0 : MonoBehaviour
{
    // Post Process Volume がついているGameObject
    [SerializeField]PostProcessVolume postProcessVolume;
    private PostProcessProfile postProcessProfile = null;

    // Start is called before the first frame update
    void OnEnable()
    {
        ColorGrading col;
        postProcessVolume.profile.TryGetSettings(out col);
        col.enabled.value = true;
        col.saturation.value = -100.0f;
    }




}
