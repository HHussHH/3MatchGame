using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIManager : MonoBehaviour
{
    public static GUIManager instance;


    public Text yourScoreTxt;
  

    public Text scoreTxt;


    private int score;
    private int moveCounter;

    void Awake()
    {
        instance = GetComponent<GUIManager>();
        moveCounter = 60;

    }
    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
            scoreTxt.text = score.ToString();
        }
    }

    public int MoveCounter
    {
        get
        {
            return moveCounter;
        }

        set
        {
            moveCounter = value;

        }
    }

    // Show the game over panel


}