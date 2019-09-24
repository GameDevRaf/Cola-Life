using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust_Particales : MonoBehaviour {

    // #region Variables

        // #region Scripts

            [Space]
            [Header ("Script")]

            [SerializeField] Player_Movement_Code player_Movement_Code;

        // #endregion

        // #region GameObject Variables

            [Space]
            [Header ("GameObject")]

            [SerializeField] GameObject Run_Dust_Particale;

            [SerializeField] GameObject Jump_Dust_Particale;

        // #endregion

        // #region Transform Variables

            [Space]
            [Header ("Transform")]

            [SerializeField] Transform Player;

        // #endregion

        // #region Vector3 Variables

            [Space]
            [Header ("Vector3")]

            private Vector3 Previous_Position;

        // #endregion

        // #region Boolean Variables

            [Space]
            [Header ("Boolean")]

            private bool Player_Is_Moving;

        // #endregion

    // #endregion

    // Update is called once per frame
    void Update() {

        if (player_Movement_Code.Player_Is_Grounded == false) {

            Run_Dust_Particale.SetActive (false);

            Jump_Dust_Particale.SetActive (true);

        }

        if (Previous_Position != Player.position) {

            Run_Dust_Particale.SetActive (true);

        }

        else if (Previous_Position == Player.position) {

            Run_Dust_Particale.SetActive (false);

        }

    }

    void FixedUpdate() {

        Previous_Position = Player.position;

    }

}
