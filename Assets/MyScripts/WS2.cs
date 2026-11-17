using System;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using Random = UnityEngine.Random;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public enum ElementalPower
{
    None,
    Fire,
    Ice,
    Lightning,
    Earth
}

[Serializable]
public struct CharInfo
{
    public string name;
    public ElementalPower elementalPower;
    public float speed;
    public int health;
    public bool canFly;
    public int damagePower;
}

public class Ws2 : MonoBehaviour
{
    public ElementalPower elementalPower;
    public CharInfo charInfo;

    public int[] values;

    private void Start()
    {
        switch (elementalPower)
        {
            case ElementalPower.Fire:
                Debug.Log("Fire");
                break;
            case ElementalPower.Ice:
                Debug.Log("Ice");
                break;
            case ElementalPower.Lightning:
                Debug.Log("Lightning");
                break;
            case ElementalPower.Earth:
                Debug.Log("Earth");
                break;
        }
        
        foreach (int i in values)
        {
            Debug.Log(i);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int variable = values[Random.Range(0, values.Length)];
            
            if (variable <= charInfo.health)
            {
                Debug.Log(variable);
            }
        }
    }
}