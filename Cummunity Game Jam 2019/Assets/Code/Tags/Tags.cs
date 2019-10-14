using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags : MonoBehaviour {

    //#region Variables

        //#region Strings

            //#region Normal Strings

                [Space]
                [Header ("String's")]

                [TextArea (0, 1)]
                public static string Horizontal_Movement = "Horizontal";

                [TextArea (0, 1)]
                public static string Vertical_Movement = "Vertical";

                [TextArea (0, 1)]
                public static string Player_Tag = "Player";

                [TextArea (0, 1)]
                public static string Obstacle_Tag = "Obstacle";

            //#endregion

            //#region Sound Strings

                [Space]
                [Header ("Sound Strings")]

                public static string Player_Jump_Sound = "Player Jump";

                public static string UI_Click_Sound = "Click Button";

                public static string Power_Up_Sound = "Power Up";

                public static string Background_Sound = "Background Theme";

                public static string Background_Sound_2 = "Background Theme 2";

            //#endregion

            //#region End_Scene Strings

                [Space]
                [Header ("End_Scene String's")]

                [TextArea (0, 1)]
                public static string Too_Less_Cola = " I am not Happy because I  drank too less COLA :( ";

                [TextArea (0,1)]
                public static string Not_Too_Much_Cola = " I wish I drank more cola so I can be more Happy :| ";

                [TextArea (0,1)]
                public static string Too_Much_Cola = " You drank too much Cola so dameged your organs then Died T_T ";

            //#endregion

        //#endregion

    //#endregion

}
