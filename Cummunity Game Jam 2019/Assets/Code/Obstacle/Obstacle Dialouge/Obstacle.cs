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

        [SerializeField] Collider2D Obstacle_Collider;

    //#endregion

      //#region Vector 3 Variables

        [Space]
        [Header ("Vector 3")]

        [SerializeField] Vector3 Cola_Position = new Vector2 (218f, 76.6f);

      //#endregion

      [SerializeField] Transform Cola;

      //#region Boolean Variables

        /*  [Space]
        [Header ("Bool")]  */

        [HideInInspector]
        public bool Text_Already_Shown = false;

      //#endregion

    //#endregion

    // Update is called once per frame
    void Update() {

        OnTriggerEnter2D (Obstacle_Collider);

    }

    void OnTriggerEnter2D (Collider2D collision) {

        if (collision.CompareTag (Tags.Player_Tag)) {

            if (Text_Already_Shown == false) {

                Bubble_Box.SetActive (true);

                Dialouge_Script.Line_Number = 1;

                StartCoroutine (Dialouge_Script.Type ());

                Dialouge_Script.Next_Button.SetActive (true);

                Text_Already_Shown = true;

            }

            Cola.position = Cola_Position;

        }

    }

}
