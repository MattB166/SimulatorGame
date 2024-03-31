using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerRanks
{
    Rookie,     //tutorial
    Pawn,       //basic tasks like painting, filing 
    Messenger,  //taking notes to higher ranking officials 
    Police,     //patrolling streets, stopping crime
    Security,   //stopping intruders into whichever building you are guarding
    Executioner,//carry out execution of prisoners 
    Paratrooper,//fight in combat zones
    Lieutenant, //give orders to small groups of soldiers, take orders from the general
    General,    //give orders to lieutenants, take orders from the fuhrer 
    Fuhrer,     //control absolutely everything. Tactics, law, police, people within organisation. Can even take down the monarchy 
    Prisoner,   //if overthrown by those below you, can spend time in jail. 
    King        //can rebel against the royals and take over the throne. have to have a LOT of public support 
}

/// <summary>
/// Manages control of all available player stats/ rank and abilities 
/// </summary>
public class PlayerController : MonoBehaviour
{
    public PlayerRanks currentRank;

    [HideInInspector] public string PlayerName { get; private set; }
    public float PlayerHealth { get; private set; }
    public float maxHealth { get; private set; } = 100;
    
    [HideInInspector] public int Influence { get; private set; }
    [HideInInspector] public int Intelligence { get; private set; }
    [HideInInspector] public int Morality { get; private set; }
    [HideInInspector] public int Leadership {  get; private set; }
    [HideInInspector] public int Strength { get; private set; }

    [HideInInspector] public int Speed { get; private set; }

    [HideInInspector] public int Tolerance { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        InitialisePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Sets base values of player
    /// </summary>
    void InitialisePlayer()
    {
        currentRank = PlayerRanks.Rookie;
        SetHealth(maxHealth);
        ///either cache the starting stats manually or by choice of external SO from different player options 
    }

    /// <summary>
    /// Switches the rank of the player 
    /// </summary>
    /// <param name="rank"></param>
    public void ChangeRank(PlayerRanks rank)
    {
        if (currentRank == rank) return;
        else
        {
            currentRank = rank;
        }
    }

    public void SetHealth(float health)
    {
        PlayerHealth = health;
    }   
}
