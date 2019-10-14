using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    //#region Variables

        //#region Script

          [Space]
          [Header ("Script")]

          [SerializeField] Dialouge Dialouge_Script;

        //#endregion

        //#region GameObject Variables

          [Space]
          [Header ("GameObject")]

          [SerializeField] GameObject Bubble_Box;

        //#endregion

        //#region Collider's

          [Space]
          [Header ("Collider's")]

          [SerializeField] Collider2D Player_Collider;

          [SerializeField] Collider2D Obstacle_1_Collider;

          [SerializeField] Collider2D Obstacle_2_Collider;

          [SerializeField] Collider2D Obstacle_3_Collider;

          [SerializeField] Collider2D Obstacle_4_Collider;

          [SerializeField] Collider2D Obstacle_5_Collider;

        //#endregion

        //#region Vector 3 Variables

          [Space]
          [Header ("Vector 3")]

          [SerializeField] Vector3 Cola_Position;

        //#endregion

        // #region Transform Variables

          [Space]
          [Header ("Transform")]

          [SerializeField] Transform Cola;

          [SerializeField] Transform Obstacles_Position;

        // #endregion

        // #region Float Variables

          [Space]
          [Header ("Float")]

          [SerializeField] float Cola_Obstacle_Position = 20.82f;

        // #endregion

        //#region Boolean Variables

          [Space]
          [Header ("Bool")]

          //[HideInInspector]
          public bool Text_Already_Shown = false;

      //#endregion

    //#endregion

    void Update() {

        Cola_Position.x = Obstacles_Position.position.x - Cola_Obstacle_Position;

        // #region On Trigger Enter 2D

            OnTriggerEnter2D (Obstacle_1_Collider);

            OnTriggerEnter2D (Obstacle_2_Collider);

            OnTriggerEnter2D (Obstacle_3_Collider);

            OnTriggerEnter2D (Obstacle_4_Collider);

            OnTriggerEnter2D (Obstacle_5_Collider);

        // #endregion

    }

    void OnTriggerEnter2D (Collider2D collision) {

        /*
        // #region Obstacle's Code

            // #region Obstacle 1's Code

                if (Obstacle_1_Collider.CompareTag (Tags.Player_Tag)) {

                    if (Text_Already_Shown == false) {

                        Bubble_Box.SetActive (true);

                        Dialouge_Script.Line_Number = 1;

                        StartCoroutine (Dialouge_Script.Type ());

                        Dialouge_Script.Next_Button.SetActive (true);

                        Text_Already_Shown = true;

                    }

                    Cola.position = Cola_Position;

                    Text_Already_Shown = true;

                }

            // #endregion

            // #region Obstacle 2's Code

                if (Obstacle_2_Collider.CompareTag (Tags.Player_Tag)) {

                    if (Text_Already_Shown == false) {

                        Bubble_Box.SetActive (true);

                        Dialouge_Script.Line_Number = 1;

                        StartCoroutine (Dialouge_Script.Type ());

                        Dialouge_Script.Next_Button.SetActive (true);

                        Text_Already_Shown = true;

                    }

                    Cola.position = Cola_Position;

                    Text_Already_Shown = true;

                }

            // #endregion

            // #region Obstacle 3's Code

                if (Obstacle_3_Collider.CompareTag (Tags.Player_Tag)) {

                    if (Text_Already_Shown == false) {

                        Bubble_Box.SetActive (true);

                        Dialouge_Script.Line_Number = 1;

                        StartCoroutine (Dialouge_Script.Type ());

                        Dialouge_Script.Next_Button.SetActive (true);

                        Text_Already_Shown = true;

                    }

                    Cola.position = Cola_Position;

                    Text_Already_Shown = true;

                }

            // #endregion

            // #region Obstacle 4's Code

                if (Obstacle_4_Collider.CompareTag (Tags.Player_Tag)) {

                    if (Text_Already_Shown == false) {

                        Bubble_Box.SetActive (true);

                        Dialouge_Script.Line_Number = 1;

                        StartCoroutine (Dialouge_Script.Type ());

                        Dialouge_Script.Next_Button.SetActive (true);

                        Text_Already_Shown = true;

                    }

                    Cola.position = Cola_Position;

                    Text_Already_Shown = true;

                }

            // #endregion

            // #region Obstacle 5's Code

                if (Obstacle_5_Collider.CompareTag (Tags.Player_Tag)) {

                    if (Text_Already_Shown == false) {

                        Bubble_Box.SetActive (true);

                        Dialouge_Script.Line_Number = 1;

                        StartCoroutine (Dialouge_Script.Type ());

                        Dialouge_Script.Next_Button.SetActive (true);

                        Text_Already_Shown = true;

                    }

                    Cola.position = Cola_Position;

                    Text_Already_Shown = true;

                }

            // #endregion

        // #endregion
        */

        if (collision.CompareTag (Tags.Player_Tag)) {

            if (Text_Already_Shown == false) {

                Bubble_Box.SetActive (true);

                Dialouge_Script.Line_Number = 1;

                StartCoroutine (Dialouge_Script.Type ());

                Dialouge_Script.Next_Button.SetActive (true);

                Text_Already_Shown = true;

            }

            Cola.position = Cola_Position;

            Text_Already_Shown = true;

        }


    }

}
