using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_End_Sound : MonoBehaviour {

    // Awake is called before Start. And Start is called before the first frame update
    void Awake() {

        FindObjectOfType <Audio_Maneger> ().Play_Sound (Tags.Background_Sound_2);

    }

}
