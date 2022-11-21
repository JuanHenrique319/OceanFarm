using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Build", menuName = "OceanFarm/Build", order = 1)]
public class BuildSO : ScriptableObject
{
    public float Wood;
    public float Rock;
    public float Mana;
    public float Pops;
    public Sprite sprite;
    public GameObject prefab;
    public float timeResource;
    public string buildName;
}