using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Creates a base template for stats on any type of character used in gameplay, and possibly the run time stats of NPCS 
/// </summary>
/// 

[CreateAssetMenu(fileName = "New Character Stats", menuName = "Character Stats/New Character Stats")]
public class CharacterStats : ScriptableObject
{
    [Header("General")]
    public string CharacterName;
    public Sprite playerImage;
    public string Description;
    
    [Header("Physical Atrributes")]
    [Range(1, 20)] public int Speed;
    [Range(1, 20)] public int Strength; //possibly not needed
    [Range(1, 20)] public int Damage;

    [Space(20)]
    [Header("Mental Attributes")]
    [Range(1,20)] public int Intelligence;
    [Range(1, 20)] public int Leadership; 


    [Space(20)]
    [Header("Social Attributes")]
    [Range(1, 20)] public int Influence;
    [Range(1, 20)] public int Tolerance;

    [Space(20)]
    [Header("Morality")]
    [Range(1, 100)] public int Morality;
}
