using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class Next_Button_2 : MonoBehaviour {

    #region Variables

      #region GameObject Variables

        [Space]
        [Header("GameObject")]

        [SerializeField] GameObject Button;

      #endregion

      #region Integer Variables

        [Space]
        [Header("Int")]

        [SerializeField] int Main_menu = 1;

      #endregion

      #region Float Variables

        [Space]
        [Header("Float")]

        [SerializeField] float Time_Before_Appear = 9.8f;

      #endregion

      #region Boolean Variables

        [Space]
        [Header ("Bool")]

        private bool Run = false;

      #endregion

    #endregion

    // Start is called before the first frame update
    void Start() {

      StartCoroutine (Appear (Time_Before_Appear));

    }

    public void Button_Clicked() {

      FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.UI_Click_Sound);

      SceneManager.LoadScene (Main_menu);

    }

    IEnumerator Appear(float Time) {

      yield return new WaitForSeconds (Time);

      Button.SetActive (true);

    }

}
