using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Code : MonoBehaviour {

    //#region Variables

      //#region Transform Variables

        [Space]
        [Header("Transform")]

        [SerializeField] Transform Player;

        [SerializeField] Transform Overlap_Circle;

      //#endregion

      //#region Rigidbody Variables

        [Space]
        [Header ("Rigidbody")]

        public Rigidbody2D Player_Rigidbody;

      //#endregion

      //#region Layers

        [Space]
        [Header ("Layers")]

        [SerializeField] LayerMask What_Is_Ground;

      //#endregion

      //#region Float Variables

        [Space]
        [Header ("Float's")]

        [Range (1f, 100f)]
        public float Movement_Speed;

        [Range (1f, 100f)]
        [SerializeField] float Jump_Force;

        [SerializeField] float Radius_Size;

      //#endregion

      //#region Integer Variables

        private int extra_Jumps;

        [Range (0, 10)]
        [SerializeField] int Extra_Jumps;

      //#endregion

      //#region Boolean Variables

        [Space]
        [Header ("Bool's")]

        [HideInInspector]
        public bool Player_Can_Move = true;

        private bool Player_is_Moving;

        [HideInInspector]
        public bool Player_is_Jumping;

        public bool Player_Is_Grounded;

        private bool Player_Facing_Right = true;

        private bool Ran = false;

      //#endregion

    //#endregion

    void Start() {

        extra_Jumps = Extra_Jumps;

    }

    // Update is called once per frame
    void Update() {

        if (Ran == false) {

            FindObjectOfType <Audio_Maneger> ().End_Sound (Tags.Background_Sound_2);

            Ran = true;

        }

        Player_Jump ();

        if (FindObjectOfType <End_Game> ().cola.Cola_Counter >= FindObjectOfType <End_Game> ().Min_Ok_Cola_Amount
        && FindObjectOfType <End_Game> ().cola.Cola_Counter <= FindObjectOfType <End_Game> ().Max_Ok_Cola_Amount) {

            Movement_Speed = FindObjectOfType <End_Game> ().Player_Movement_Speed_Minus_12_point_5_Percent;

        }

        if (FindObjectOfType <End_Game> ().cola.Cola_Counter >=
        FindObjectOfType <End_Game> ().Too_Much_Cola_Amount) {

            Movement_Speed = FindObjectOfType <End_Game> ().
            Player_Movement_Speed_Minus_25_Percent;

        }

    }

    // FixedUpdate is called 2-4 times per frame
    void FixedUpdate() {

        Player_Is_Grounded = Physics2D.OverlapCircle (Overlap_Circle.position, Radius_Size, What_Is_Ground);

        float Move_Input = Input.GetAxis (Tags.Horizontal_Movement);

        if (Player_Can_Move == true) {

            Player_Rigidbody.velocity = new Vector2 (Move_Input * Movement_Speed, Player_Rigidbody.velocity.y);

            if (Player_Facing_Right == false && Move_Input > 0) {

                Flip_Player ();

            }

            else if (Player_Facing_Right == true && Move_Input < 0) {

                Flip_Player ();

            }

        }

    }


    //       ___ _                          _                      ___         _
    //     | _ \ |__ _ _  _ ___ _ _     _ | |_  _ _ __  _ __     / __|___  __| |___
    //     |  _/ / _` | || / -_) '_|   | || | || | '  \| '_ \   | (__/ _ \/ _` / -_)
    //     |_| |_\__,_|\_, \___|_|      \__/ \_,_|_|_|_| .__/    \___\___/\__,_\___|
    //                 |__/                            |_|


    void Player_Jump() {

        if (Player_Is_Grounded == true) {

            extra_Jumps = Extra_Jumps;

            Player_is_Jumping = false;

        }

        if (Player_Can_Move == true) {

            //#region Jump when W Key pressed

            if (Input.GetKeyDown (KeyCode.W) && extra_Jumps > 0) {

                Player_is_Jumping = true;

                FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.Player_Jump_Sound);

                Player_Rigidbody.velocity = Vector2.up * Jump_Force;

                extra_Jumps --;

            }

            if (Input.GetKeyDown (KeyCode.W) && extra_Jumps <= 0 && Player_Is_Grounded == true) {

                Player_is_Jumping = true;

                FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.Player_Jump_Sound);

                Player_Rigidbody.velocity = Vector2.up * Jump_Force;

            }

            //#endregion

            //#region Jump when Up Arrow Key pressed

            if (Input.GetKeyDown (KeyCode.UpArrow) && extra_Jumps > 0) {

                Player_is_Jumping = true;

                FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.Player_Jump_Sound);

                Player_Rigidbody.velocity = Vector2.up * Jump_Force;

                extra_Jumps --;
            }

            if (Input.GetKeyDown (KeyCode.UpArrow) && extra_Jumps <= 0 && Player_Is_Grounded == true) {

                Player_is_Jumping = true;

                FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.Player_Jump_Sound);

                Player_Rigidbody.velocity = Vector2.up * Jump_Force;

            }

            //#endregion

            //#region Jump when Space Key pressed

            if (Input.GetKeyDown (KeyCode.Space) && extra_Jumps > 0) {

                Player_is_Jumping = true;

                FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.Player_Jump_Sound);

                Player_Rigidbody.velocity = Vector2.up * Jump_Force;

                extra_Jumps --;

            }

            if (Input.GetKeyDown (KeyCode.Space) && extra_Jumps <= 0 && Player_Is_Grounded == true) {

                Player_is_Jumping = true;

                FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.Player_Jump_Sound);

                Player_Rigidbody.velocity = Vector2.up * Jump_Force;

            }

            //#endregion

        }

    }

    void Flip_Player() {

        Player_Facing_Right = !Player_Facing_Right;

        Vector3 Scalor = Player.localScale;

        Scalor.x *= -1;

        Player.localScale = Scalor;

    }

}
