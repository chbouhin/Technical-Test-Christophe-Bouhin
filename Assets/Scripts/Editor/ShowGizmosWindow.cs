using UnityEngine;
using UnityEditor;
using technical.test.editor;
using UnityEditor.Callbacks;
using System.Collections.Generic;

public class ShowGizmosWindow : EditorWindow
{
    private SceneGizmoAsset sceneGizmoAsset;
    private Gizmo[] gizmos;
    private List<VisualClass> gos = new List<VisualClass>();

    [MenuItem("Window/Custom/Show Gizmos")]
    public static void ShowWindow()
    {
        ShowGizmosWindow window = (ShowGizmosWindow)EditorWindow.GetWindow(typeof(ShowGizmosWindow));
        window.Show();
        window.InitWithMenu();
        window.CreateGos();
    }

    private void InitWithMenu()
    {
        sceneGizmoAsset = AssetDatabase.LoadAssetAtPath<SceneGizmoAsset>("Assets/Data/Editor/Scene Gizmo Asset.asset");
        if (!sceneGizmoAsset) {
            // Create SceneGizmoAsset if data not found
            sceneGizmoAsset = CreateInstance<SceneGizmoAsset>();
            AssetDatabase.CreateAsset(sceneGizmoAsset, "Assets/Data/Editor/Scene Gizmo Asset.asset");
            AssetDatabase.Refresh();
        }
        gizmos = sceneGizmoAsset.GetGizmos();
    }

    private void InitWithSO(SceneGizmoAsset editedAsset)
    {
        sceneGizmoAsset = editedAsset;
        gizmos = sceneGizmoAsset.GetGizmos();
        CreateGos();
    }

    private void CreateGos()
    {
        if (gizmos == null)
            return;
        DestroyGos();
        for (int i = 0; i < gizmos.Length; i++) {
            gos.Add(new GameObject().AddComponent<VisualClass>());
            gos[i].transform.position = gizmos[i].Position;
            gos[i].SetTitle(gizmos[i].Name);
        }
    }

    private void DestroyGos()
    {
        for (int i = 0; i < gos.Count; i++) {
            DestroyImmediate(gos[i].gameObject);
            gos.RemoveAt(i);
            i--;
        }
    }

    private void OnGUI()
    {
        // Create UI Editor
        GUILayout.Label("Gizmo Editor", EditorStyles.boldLabel);
        GUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Text");
        EditorGUILayout.LabelField("Position");
        GUILayout.EndHorizontal();

        // Loop in gizmos data to create UI array
        for (int i = 0; gizmos != null && i < gizmos.Length; i++) {
            GUILayout.BeginHorizontal();
            gizmos[i].Name = EditorGUILayout.TextField("", gizmos[i].Name);
            gizmos[i].Position = EditorGUILayout.Vector3Field("", gizmos[i].Position);
            if (GUILayout.Button("Edit")) {
                gos[i].transform.position = gizmos[i].Position;
                gos[i].UpdatePosition();
            }
            GUILayout.EndHorizontal();
            if (gos[i].HaveMove()) {
                gizmos[i].Position = gos[i].transform.position;
                gos[i].UpdatePosition();
            }
        }
    }

    [OnOpenAssetAttribute]
    public static bool OpenData(int instanceId, int line)
    {
        // Getting instance id of object when clicking on it
        SceneGizmoAsset editedAsset = EditorUtility.InstanceIDToObject(instanceId) as SceneGizmoAsset;
        if (editedAsset == null)
            return false;
        ShowGizmosWindow window = (ShowGizmosWindow)EditorWindow.GetWindow(typeof(ShowGizmosWindow));
        window.Show();
        window.InitWithSO(editedAsset);
        return true;
    }

    private void OnDestroy()
    {
        DestroyGos();
    }
}
