using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Laod : MonoBehaviour {

    // <editor-fold Variables

      // <editor-fold GameObject Variables

        [Space]
        [Header ("GameObject")]

        [SerializeField] GameObject Panel;

      // </editor-fold>

      // <editor-fold Integer Variables

        [Space]
        [Header ("Int")]

        [SerializeField] int Main_menu_Scene = 1;

        public static int Load_Main_Menu;
        public static int Destroy_Object;

      // </editor-fold>

    // </editor-fold>

    // Start is called before the first frame update
    void Start() {

        // Destroy the Panel if Destroy_Object is equal to 1.
        if (Destroy_Object == 1) {

            Panel.SetActive (false);

            Destroy (Panel);

        }

        // Load the Main Menu scene if Load_Main_Menu is equal to 0.
        if (Load_Main_Menu == 0) {

            SceneManager.LoadScene (Main_menu_Scene);

            Load_Main_Menu = 1;

        }

        // Make the variables so that Destroy_Object will run if Load_Main_Menu is equal to 1.
        if (Load_Main_Menu == 1) {

            Destroy_Object = 1;

            Load_Main_Menu = 1;

        }

    }

}
