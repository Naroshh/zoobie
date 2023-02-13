using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyBox : MonoBehaviour
{
    public Material SkyMaterial;
    // Start is called before the first frame update
    void Start()
    {
        RenderingSettings.skybox = SkyMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
