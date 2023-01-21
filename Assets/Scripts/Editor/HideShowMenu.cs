using UnityEngine;
using UnityEditor;

public class HideShowMenu
{
    [MenuItem("Hidden Objects/Hide Show Objects")]
    static void HideObjMenu()
    {
        HideFlags hideFlags = HideFlags.None;
        bool firstObj = true;

        foreach (VisualClass visualClass in GameObject.FindObjectsOfType<VisualClass>()) {
            if (firstObj) {
                firstObj = false;
                if (hideFlags == visualClass.gameObject.hideFlags)
                    hideFlags = HideFlags.HideInHierarchy;
            }
            visualClass.gameObject.hideFlags = hideFlags;
        }
    }
}
