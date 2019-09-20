using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Camera_Follow_Player : MonoBehaviour {

    #region Variables
      
      [Space]
      [Header ("Variables")]
      
      Cinemachine.CinemachineVirtualCameraBase Cinemachine_Camera;
      
      [SerializeField] Transform Player_fat;

    #endregion

    private void Awake() {

        Cinemachine_Camera = GetComponent <Cinemachine.CinemachineVirtualCamera> ();

    }

    // Update is called once per frame

    void Update() {

        if (FindObjectOfType <End_Game> ().cola.Cola_Counter >= FindObjectOfType <End_Game> ().Too_Much_Cola_Amount && FindObjectOfType <Change_Body> ().Already_Spawned_Player == 1) {

           GetComponent <CinemachineVirtualCamera> ().m_Follow = Player_fat.transform;

            FindObjectOfType <Change_Body> ().Already_Spawned_Player = 2;

        }

    }

}
