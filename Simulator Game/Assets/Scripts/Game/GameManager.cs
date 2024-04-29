using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameMode
{
    Menu,
    Level

}
public enum CameraMode
{
    RotateFollow,
    Fixed
}
/// <summary>
/// Manages all Gameplay flow and surrounding features. Central hub for all scenarios 
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float PlayerXP { get; private set; }  //used to control player level and rank

    private PlayerController player;
    private GameMode gameMode;
    private CameraMode cameraMode;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

        player = FindFirstObjectByType<PlayerController>();

    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChooseCharacter()
    {
        ///choose character from list of available characters. later version  

    }

    public void AddXP(float xp)
    {
        PlayerXP += xp;
        ///check if player has levelled up 
        ///    }
    }


}
