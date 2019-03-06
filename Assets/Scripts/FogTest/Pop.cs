    using UnityEngine;
    using System.Collections;

    public class Pop : MonoBehaviour {
    private float Ypos1=0.0f;
    private float Ypos2=0.0f;
    private float Ypos3=0.0f;
    private float Ypos4=0.0f;
    private float Ypos5=0.0f;
    private bool showDropdownButtons1 ;
    private bool showDropButtonsUP1;
    float dropSpeed   = 500.0f;
    private string St="FogMode";    
    void Start() {
    }
    void Update(){
        if(showDropdownButtons1 == true){
            Ypos1 += Time.deltaTime * dropSpeed;   
            Ypos2 += Time.deltaTime * dropSpeed;   
            Ypos3 += Time.deltaTime * dropSpeed;
            Ypos4 += Time.deltaTime * dropSpeed;
            if(Ypos1 >= 60){
                Ypos1 = 60;
            }
            if(Ypos2 >= 120){
                Ypos2 = 120;
            }
            if(Ypos3 >= 180){
                Ypos3 = 180;
            }
            if(Ypos4 >= 240){
                Ypos4 = 240;
            }
            if(showDropButtonsUP1 == true){
                Ypos1 -= Time.deltaTime * dropSpeed;
                Ypos2 -= Time.deltaTime * dropSpeed;
                Ypos3 -= Time.deltaTime * dropSpeed;
                Ypos4 -= Time.deltaTime * dropSpeed;
                if(Ypos1 >= 0 || Ypos2 >= 0 || Ypos3 >= 0 || Ypos4 >= 0){
                    Ypos1 = 0;
                    Ypos2 = 0;
                    Ypos3 = 0;
                    Ypos4 = 0;
                    showDropButtonsUP1 = false;
                    showDropdownButtons1 = false;  
                }
            }
        }
    }
        void OnGUI (){
            if(showDropdownButtons1 == false){
                if (GUI.RepeatButton (new Rect (50, 0, 200, 60), St)){
                    showDropdownButtons1 = true;
                }
            }
            if(showDropdownButtons1 == true){

                if (GUI.Button(new Rect(50, 0, 200, 60), St))
                {
                    showDropButtonsUP1 = true;
                    showDropdownButtons1 = false;
                }

                if (GUI.Button(new Rect(50, Ypos1, 200, 60), "Linear"))
                {
                    showDropButtonsUP1 = true;
                    showDropdownButtons1 = false;
                    RenderSettings.fogMode = FogMode.Linear;
                    St = "Linear";
                }
                if (GUI.Button(new Rect(50, Ypos2, 200, 60), "Exp2"))
                {

                    showDropButtonsUP1 = true;
                    showDropdownButtons1 = false;
                    RenderSettings.fogMode = FogMode.ExponentialSquared;
                    St = "Exp2";

                }
                if (GUI.Button(new Rect(50, Ypos3, 200, 60), "Exponential"))
                {
 
                    showDropButtonsUP1 = true;
                    showDropdownButtons1 = false;
                    RenderSettings.fogMode = FogMode.Exponential;
                    St = "Exponential";
                }
                if (GUI.Button(new Rect(50, Ypos4, 200, 60), "None"))
                {

                    showDropButtonsUP1 = true;
                    showDropdownButtons1 = false;
                    RenderSettings.fogMode = 0;
                    St = "None";
                }
            }
        }   
    }
