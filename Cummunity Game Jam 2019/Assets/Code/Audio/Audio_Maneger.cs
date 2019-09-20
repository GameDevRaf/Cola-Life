using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using System;

public class Audio_Maneger : MonoBehaviour {

  #region Variables

      #region Scripts

        [Space]
        [Header ("Script")]

        public Sounds[] Sounds;

      #endregion

      #region Audio Variables

        public static Audio_Maneger Instance;

      #endregion

    #endregion

    void Awake() {

        if (Instance == null) {

          Instance = this;

        }

        else {

          Destroy (gameObject);

          return;

        }

        DontDestroyOnLoad (gameObject);

        foreach (Sounds sound in Sounds) {

          sound.Audio_Source = gameObject.AddComponent <AudioSource> ();

          sound.Audio_Source.clip = sound.Audio_Clip;

          sound.Audio_Source.volume = sound.Volume;
          sound.Audio_Source.pitch = sound.Pitch;
          sound.Audio_Source.loop = sound.Loop;

        }

    }

    void Start() {

      Play_Sound (Tags.Background_Sound);

    }

    public void Play_Sound (string name) {

      Sounds sound = Array.Find (Sounds, Sounds => Sounds.Name == name);

      if (sound == null) {

        Debug.LogWarning ("Your sound which is called: " + name + " isn't found see if you spelled it wrong");

        return;

      }

      sound.Audio_Source.Play ();

    }

    public void End_Sound (string name) {

      Sounds sound = Array.Find (Sounds, Sounds => Sounds.Name == name);

      if (sound == null) {

        Debug.LogWarning ("Your sound which is called: " + name + " isn't found see if you spelled it wrong");

        return;

      }

      sound.Audio_Source.Stop ();

    }

}
