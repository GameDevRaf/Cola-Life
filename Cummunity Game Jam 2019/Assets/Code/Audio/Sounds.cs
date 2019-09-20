using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sounds {

    #region Variables
      
      #region String Variables
        
        [Space]
        [Header("String")]

        public string Name;
        
      #endregion
      
      #region Audio Variables
        
        [Space]
        [Header ("Audio Clip")]

        public AudioClip Audio_Clip;
        
        [HideInInspector]
        public AudioSource Audio_Source;
        
      #endregion
      
      #region Float Variables
        
        [Space]
        [Header ("Float's")]

        [Range (0f, 1f)]
        public float Volume;
        
        [Range (0.1f, 3f)]
        public float Pitch;
        
      #endregion
      
      #region Boolean Variables
        
        [Space]
        [Header ("Bool")]

        public bool Loop;
        
      #endregion
      
    #endregion

}
