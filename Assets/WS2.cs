using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class WS2 : MonoBehaviour
{
    public floar timer = 5f;
    public EventInstance instance;
    public EventReference reference;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = RuntimeManager.CreateInstance(reference);
        instance.start();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            instance.setParameterByName("Distance", 1);

        }  
    }
}
