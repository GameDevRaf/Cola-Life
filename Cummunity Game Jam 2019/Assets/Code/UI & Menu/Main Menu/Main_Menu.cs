using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main_Menu : MonoBehaviour {

    #region Variables     
      
      #region Integer Variables
        
        [Space]
        [Header ("Int")]

        [SerializeField] int Start_Scene = 2;

    #endregion

    #endregion

    void Awake() {

        FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.Background_Sound_2);

    }

    public void Play_Game() {

        FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.UI_Click_Sound);

        SceneManager.LoadScene (Start_Scene);

    }

    public void Quit_Game() {

        FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.UI_Click_Sound);

        Application.Quit ();

    }

}
