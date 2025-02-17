﻿using UnityEngine;

namespace Project.HighwayRacer {
  [System.Serializable]
  public class HR_Wheels : ScriptableObject {
    public static HR_Wheels instance;

    public static HR_Wheels Instance {
      get {
        if (instance == null)
          instance = Resources.Load("HR_Assets/HR_Wheels") as HR_Wheels;
        return instance;
      }
    }

    [System.Serializable]
    public class Wheels {
      public GameObject wheel;
      public bool unlocked;
      public int price;
    }

    public Wheels[] wheels;
  }
}