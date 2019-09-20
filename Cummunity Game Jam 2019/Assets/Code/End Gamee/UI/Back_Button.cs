using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Back_Button : MonoBehaviour {

    #region Variables

      #region Script
        
        [Space]
        [Header("Script")]
        
        [SerializeField] Player_Movement_Code player_Movement;
        
      #endregion

    #region Integer Variables

    // [Space]
    // [Header ("Int")]

    private int Main_Menu = 1;

      #endregion
      
    #endregion

    public void Back() {

        player_Movement.Player_Can_Move = true;

        FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.UI_Click_Sound);

        SceneManager.LoadScene (Main_Menu);

    }

}
