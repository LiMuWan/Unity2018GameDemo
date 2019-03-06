//using UnityEngine;
//using System.Collections;

//public class Controler : MonoBehaviour {
//    public EasyJoystick MyJoystick;
//    CharacterController controller;
//    float RunSpeed;
//    Vector3 MoveDrection ;
//    public GameObject CameraA;
//	void Start () {
//        controller = (CharacterController)this.GetComponent("CharacterController");
//        controller.slopeLimit = 30.0f;
//        RunSpeed = 1000;
//	}
//	void Update () {
//        MoveDrection = new Vector3(Input.GetAxis("Fire1"), 0, 0);
//        MoveDrection = transform.TransformDirection(MoveDrection);
//        if (MyJoystick.JoystickTouch.y == 0 && MyJoystick.JoystickTouch.x == 0) {
//            GetComponent<Animation>().Play("Laugh");
//        }
//        if (MyJoystick.JoystickTouch.y > 0.5f) {
//                GetComponent<Animation>().Play("Run");    
//        }
//        if (MyJoystick.JoystickTouch.x < -0.5f)
//        {
//            this.transform.Rotate(0, -1.0f, 0);
//        }
//        if (MyJoystick.JoystickTouch.x > 0.5f)
//        {
//            this.transform.Rotate(0, 1.0f, 0);
//        }
//        if (MyJoystick.JoystickTouch.y < -0.5f)
//        {
//            CameraA.transform.Translate(Vector3.back);
//        }
//        if(GetComponent<Animation>().IsPlaying("Run")){
//            controller.SimpleMove(MoveDrection * (Time.deltaTime * RunSpeed));
//        }
//	}
//}
