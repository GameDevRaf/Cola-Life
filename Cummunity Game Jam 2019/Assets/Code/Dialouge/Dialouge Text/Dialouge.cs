using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialouge : MonoBehaviour {

    #region Variables
      
      #region GameObject Variables
        
        [Space]
        [Header ("GameObject's")]

        public GameObject Next_Button;
        
        public GameObject Bubble_Box;
        
      #endregion
      
      #region TextMeshPro Variables
        
        [Space]
        [Header ("Text Mesh Pro")]

        public TextMeshProUGUI Text;
        
      #endregion
      
      #region String Variables
        
        [Space]
        [Header ("String")]

        [TextArea(1, 4)]
        public string[] Sentences;
        
      #endregion

      #region Float Variables
      
        [Space]
        [Header ("Float")]

        public float Typing_Speed;
        
      #endregion

      #region Integer Variables

        // [Space]
        // [Header ("Int")]

        [HideInInspector]
        public int Index;
        
        [HideInInspector]
        public int Line_Number;
        
      #endregion

    #endregion
    
    // Update is called once per frame
    void Update() {

        if (Text.text == Sentences [Index]) {

            Next_Button.SetActive (true);

            Bubble_Box.SetActive (true);

        }

    }

    public IEnumerator Type() {

        foreach (char letter in Sentences [Line_Number].ToCharArray ()) {

            Text.text += letter;

            yield return new WaitForSeconds (Typing_Speed);

        }

    }

    public void Next_Sectence() {

        FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.UI_Click_Sound);

        if (Index < Sentences.Length -1) {

            Next_Button.SetActive (false);

            Index ++;

            Text.text = "";

            // StartCoroutine (Type ());

            Bubble_Box.SetActive (false);

        }

        else {

            Text.text = "";

            Next_Button.SetActive (false);

            Bubble_Box.SetActive (false);

        }

        FindObjectOfType <Obstacle> ().Text_Already_Shown = false;

    }

}
