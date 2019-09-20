using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Body : MonoBehaviour {

    #region Variables      
      
      #region GameObject Variables
        
        [Space]
        [Header ("Game Object's")]

        [SerializeField] GameObject Player_Thin;
        
        public GameObject Player_Fat;

    #endregion
      
      #region Integer Variables

        [Space]
        [Header ("Int")]

        [HideInInspector]
        public int Already_Spawned_Player = 0;

    #endregion

    #endregion

    private void Start() {
        


    }

    // Update is called once per frame
    void Update() {

        if (FindObjectOfType <End_Game> ().cola.Cola_Counter >= FindObjectOfType <End_Game> ().Too_Much_Cola_Amount && Already_Spawned_Player == 0) {

            Vector3 Spawn_Position = new Vector3 (Player_Thin.transform.position.x, Player_Thin.transform.position.y + 3.32f, 0);

            Player_Thin.SetActive (false);

            Instantiate (Player_Fat, Spawn_Position, Quaternion.identity);

            Already_Spawned_Player = 1;

        }

    }

}
