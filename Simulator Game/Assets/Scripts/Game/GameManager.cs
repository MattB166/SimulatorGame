using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameMode
{
    Menu,
    Level

}
/// <summary>
/// Manages all Gameplay flow and surrounding features. Central hub for all scenarios 
/// </summary>
public class GameManager : MonoBehaviour
{
    [System.Serializable]
    public struct Tasks
    {
        public PlayerRanks rank;
        public List<string> tasks; //change to another type of some sort 
        ///SO denoting task stats and rules 
    }
    public List<Tasks> PossibleTasks = new(); 
    public static GameManager instance;
    public float PlayerXP { get; private set; }

    private PlayerController player;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
