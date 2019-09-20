using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class End_Game : MonoBehaviour {

    #region Variables

      #region Scripts

        [Space]
        [Header ("Script's")]

        public Cola cola;

        [SerializeField] Player_Movement_Code player_Movement;

      #endregion

      #region GameObject Variables

        [Space]
        [Header ("Game Object's")]

        [SerializeField] GameObject Player;

        [SerializeField] GameObject End_Scene;

      #endregion

      #region Text Variables

        [Space]
        [Header ("Text Mesh Pro")]

        [SerializeField] TextMeshProUGUI End_Text;

      #endregion

      #region Collider's

        [Space]
        [Header ("Collider")]

        [SerializeField] Collider2D Door_Collider;

    #endregion

      #region Float Variables

        [Space]
        [Header ("Float's")]

        public float Player_Movement_Speed_Minus_12_point_5_Percent = 11.375f;

        public float Player_Movement_Speed_Minus_25_Percent = 9.75f;

      #endregion

      #region Integer Variables

        [Space]
        [Header ("Int's")]

        [SerializeField] int End_scene = 0;

        public int Too_Less_Cola_Amount;

        public int Min_Ok_Cola_Amount;
        public int Max_Ok_Cola_Amount;

        public int Too_Much_Cola_Amount;

    #endregion

    #endregion

    // Update is called once per frame
    void Update()  {

       OnTriggerEnter2D (Door_Collider);

    }

    void OnTriggerEnter2D (Collider2D collision) {

        if (collision.CompareTag (Tags.Player_Tag)) {

            if (cola.Cola_Counter <= Too_Less_Cola_Amount) {

                /*player_Movement.Player_Can_Move = false;

                player_Movement.Player_Rigidbody.isKinematic = true;

                End_Text.text = Tags.Too_Less_Cola;

                End_Scene.SetActive (true);*/

                SceneManager.LoadScene (End_scene);

            }

              if (cola.Cola_Counter >= Min_Ok_Cola_Amount && cola.Cola_Counter  <= Max_Ok_Cola_Amount) {

                /*player_Movement.Player_Can_Move = false;

                player_Movement.Player_Rigidbody.isKinematic = true;

                End_Text.text = Tags.Not_Too_Much_Cola;

                End_Scene.SetActive (true);*/

                SceneManager.LoadScene (End_scene);

            }

              if (cola.Cola_Counter >= Too_Much_Cola_Amount) {

                /*player_Movement.Player_Can_Move = false;

                player_Movement.Player_Rigidbody.isKinematic = true;

                Destroy (Player);

                End_Text.text = Tags.Too_Much_Cola;

                End_Scene.SetActive (true);*/

                SceneManager.LoadScene (End_scene);

            }

        }

    }

}
