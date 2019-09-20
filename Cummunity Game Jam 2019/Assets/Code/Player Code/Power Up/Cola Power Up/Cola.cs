using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Cola : MonoBehaviour {

    //#region Variables

      //#region Script

        // [Space]
        // [Header ("Script")]

        private Player_Movement_Code Player;

      //#endregion

      //#region GameObject Variables

        [Space]
        [Header ("GameObject")]

        public GameObject Cola_GameObject;

        [SerializeField] GameObject Collect_Cola_Particle;

      //#endregion

      //#region TextMeshPro Variables

      [Space]
      [Header("Text Mesh Pro")]

      [SerializeField] TextMeshProUGUI Cola_Counter_Text;

      //#endregion

      //#region Collider's

        [Space]
        [Header ("Colliders")]

        [SerializeField] Collider2D Player_Collider;

        [SerializeField] Collider2D Cola_Collider;

      //#endregion

      //#region Integer Variables

        /* [Space]
           [Header ("Int")] */

        [HideInInspector]
        public int Cola_Counter = 0;

      //#endregion

    //#endregion

    void Update() {

        OnTriggerEnter2D (Cola_Collider);

    }

    void OnTriggerEnter2D (Collider2D collision) {

        if (collision.CompareTag (Tags.Player_Tag)) {

            Instantiate (Collect_Cola_Particle, Cola_GameObject.transform.position,
            Quaternion.identity);

            FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.Power_Up_Sound);

            Cola_Counter ++;

            Cola_Counter_Text.text = Cola_Counter.ToString();

        }

    }


}
