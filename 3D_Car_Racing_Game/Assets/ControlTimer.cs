using UnityEngine;
using System.Collections;
using System.Timers;
using System.Threading;
using UnityEngine.UI;

public class ControlTimer : MonoBehaviour {
    public Text wingame;
    private void OnTriggerEnter(Collider other)
    {   


        if (other.gameObject.name == "startRace2")
        {
            SetTimer(1);
            Debug.Log("Hit to Start");
        }

        if (other.gameObject.name == "finishRace2")
        {
            SetTimer(0);
            Debug.Log("Hit to Finish");

            WinGame();

        }


    }



    public void WinGame()
    {
        Debug.Log("WIN");

        wingame.text = "Congrats! \n You win";

    }

    //void OnControllerColliderHit(ControllerColliderHit hit) {

    //	if(hit.gameObject.name == "startRace2")
    //	{
    //		//SetTimer(1);
    //		Debug.Log("Hit to Start");
    //	}

    //	if(hit.gameObject.name == "finishRace2")
    //	{
    //		//SetTimer(0);
    //		Debug.Log("Hit to Finish");
    //	}

    //}

    void SetTimer(int t)
    {
        Timer playerTimer = this.GetComponent<Timer>();
        playerTimer.startTimer = t;
    
       Debug.Log("startTimer: " + playerTimer.startTimer);
    }
}