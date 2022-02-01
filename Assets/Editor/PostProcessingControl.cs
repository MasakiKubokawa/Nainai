using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingControl : MonoBehaviour
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
        col.saturation.value = 0.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
         ColorGrading col;
        postProcessVolume.profile.TryGetSettings(out col);
        col.saturation.Override(0.0f);
        //postProcessVolume = PostProcessManager.instance.QuickVolume(gameObject.layer, 0f, col);
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        ColorGrading col;
        postProcessVolume.profile.TryGetSettings(out col);
        col.saturation.Override(0.0f);
        //postProcessVolume = PostProcessManager.instance.QuickVolume(gameObject.layer, 0f, col);
    }
}
