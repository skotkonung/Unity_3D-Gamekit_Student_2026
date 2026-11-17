using System;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public enum ElementalPower
{
    None,
    Fire,
    Ice,
    Lightning,
    Earth
}

[System.Serializable]
public struct CharInfo
{
    public string name;
    public ElementalPower elementalPower;
    public float speed;
    public int health;
    public bool canFly;
    public int damagePower;
}

public class WS2 : MonoBehaviour
{
    public ElementalPower elementalPower;
    public CharInfo charInfo;

    public int[] highScores;
    
    private void Start()
    {
        Debug.Log(elementalPower);
        Debug.Log(charInfo.name);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
                Debug.Log("Triggered by " + other);
        }
    }*/
}