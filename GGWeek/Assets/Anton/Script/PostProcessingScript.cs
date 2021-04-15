using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingScript : MonoBehaviour
{

public PostProcessVolume volume;
private Vignette vignette;
public int zone;


    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings(out vignette);
        vignette.smoothness.value = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.T))
      {
        if(zone==2){
          vignette.intensity.value=0.5f;
        }
        if(zone==1){
          vignette.intensity.value=0.4f;
          zone=2;
        }
        if(zone==0){
          vignette.intensity.value=0.2f;
          zone=1;
        }
      }
    }
}
