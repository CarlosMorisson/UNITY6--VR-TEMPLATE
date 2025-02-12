using UnityEngine;

public class SetCamToChat : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject cam;
    

    void OnEnable()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        this.GetComponent<Canvas>().renderMode = RenderMode.WorldSpace;
        this.GetComponent<Canvas>().worldCamera=cam.GetComponent<Camera>();
 


    }
}
