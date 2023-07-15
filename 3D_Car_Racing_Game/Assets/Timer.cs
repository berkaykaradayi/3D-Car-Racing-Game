using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerLabel;
    public Text gameover;
   

    public float startTimer=0;
    float startTime;
     public int minutes, seconds,fraction;


    public float timer = 6; // it was float

    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        float guiTime = timer  - (Time.time - startTime);
        
        /*( for increment minutes/ remove comment site////////// and (-) to make countdown from 1 min ////////// ) */
        
        
        if (startTimer > 0 && guiTime >0) //&& guiTime >0) //it was guiTime / we need guiTime for 0:0:0 otherwise it will keep decrement the countdown
        {
             minutes = (int)(guiTime / 60);
             seconds = (int)(guiTime % 60);
             fraction = (int)((guiTime * 100) % 100); // (int)

            timerLabel.text = string.Format("{0:00}:{1:00}", minutes, seconds);
         
                if ((minutes == 0 && seconds == 0) )
            {
                Debug.Log("startTimer: " + startTimer);


                GameOver();
             }
            

             else if(startTimer == 0)
            {
                Debug.Log("startTimer: " + startTimer);


            }
        
        
        }

        else 
        {
            //Do nothing
        
        
        }
       
    
    }


    
    public void GameOver()
    {
        gameover.text = "GAME OVER!\n  YOU LOST";

        //Debug.Log("Game is Over");
       // Application.Quit();

        //SceneManager.LoadScene(1);/*make sure to make a game over scene with gameover text and add the scene to
        //the build settings and replace that 1 with index*/

    }




}



//using UnityEngine; ////////////İLK VERSİYON 
//using UnityEngine.UI;
//using System.Timers;

//public class Timer : MonoBehaviour {
//	public Text timerLabel;
//	public float startTimer = 0;

//	private float time;

//	void Update() {


//		if (this.startTimer >= 0)
//		{
//			time += Time.deltaTime;

//			var minutes = time / 60; //Divide the guiTime by sixty to get the minutes. // changed it to 120(most correct one)
//			var seconds = time % 60;//Use the euclidean division for the seconds.
//			//var fraction = (time * 100) % 100;

//			var fraction = time * 1000;
//			var fraction2 = (fraction % 1000);


//			//update the label value
//			timerLabel.text = string.Format ("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction2);
//		}
//        else
//        {
//			timerLabel.text = "Timer Not working";
//			//do nothing
//		}
//	}



//}




