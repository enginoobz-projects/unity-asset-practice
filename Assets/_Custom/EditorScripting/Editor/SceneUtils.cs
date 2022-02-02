using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEditor;

namespace Enginoobz.Editor {
  public static class SceneUtils {
    public static void CreateEmptyScene() {
      EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
      EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
    }

    public static void CleanScene() {
      // ? Separate confirm dialog code   
      if (EditorUtility.DisplayDialog(
        "Clean Scene",
        "Are you sure to remove all GameObjects?",
        "Yes",
        "No"
      )) {
        var gos = Object.FindObjectsOfType<GameObject>();
        foreach (var go in gos) {
          GameObject.DestroyImmediate(go);
        }
      }
    }
  }
}