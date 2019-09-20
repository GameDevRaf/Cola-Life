using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cola_End : MonoBehaviour {

    #region Scripts

    [Space]
    [Header("Script's")]

    [SerializeField] Dialouge Dialouge_Script;

    #endregion

    #region GameObject Variables

    [Space]
    [Header("GameObject")]

    [SerializeField] GameObject Bubble_Box;

    #endregion

    [SerializeField] Collider2D Door;

    [SerializeField] Transform Cola;

    [SerializeField] Vector3 Cola_Position = new Vector2 (990f, 76.6f);

    // Update is called once per frame
    void Update() {

        OnTriggerEnter2D (Door);

    }

    void OnTriggerEnter2D (Collider2D collision) {

        if (collision.CompareTag (Tags.Player_Tag)) {

            Bubble_Box.SetActive (true);

            Dialouge_Script.Line_Number = 6;

            FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.UI_Click_Sound);

            Dialouge_Script.Text.text = "";

            StartCoroutine (Dialouge_Script.Type ());

            Dialouge_Script.Next_Button.SetActive (true);

            Cola.position = Cola_Position;

        }

    }

}
