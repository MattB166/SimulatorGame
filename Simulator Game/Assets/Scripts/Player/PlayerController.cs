using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerRanks
{
    Rookie,     //tutorial
    Pawn,       //basic tasks like painting, filing 
    Messenger,  //taking notes to higher ranking officials 
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
    public float PlayerHealth { get; private set; }
    
    [HideInInspector] public float Influence { get; private set; }
    [HideInInspector] public float Intelligence { get; private set; }
    [HideInInspector] public float Morality { get; private set; }
    [HideInInspector] public float Leadership {  get; private set; }
    [HideInInspector] public float Strength { get; private set; }

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
}
