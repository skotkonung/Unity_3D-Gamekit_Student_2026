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
    public CharInfo[] charInfo;

    public int[] values;

    private void Start()
    {
        foreach (CharInfo info in charInfo)
        {
            switch (info.name)
            {
                case "Sebbe":
                    Debug.Log("Har du spelat Metroid?");
                    break;
                case "Samus":
                    Debug.Log("...");
                    break;
                case "Mario":
                    Debug.Log("Wahoo!");
                    break;
                default:
                    Debug.Log("Ajdå");
                    break;
            }
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int variable = values[Random.Range(0, values.Length)];
            
            if (variable <= charInfo[0].health)
            {
                Debug.Log(variable);
            }
        }
    }
}