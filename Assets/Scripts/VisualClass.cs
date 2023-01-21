using UnityEngine;
using UnityEditor;
using System;

public class VisualClass : MonoBehaviour
{
    private string title;
    private bool haveInit = false;
    private Vector3 lastPos;

    private void Init()
    {
        haveInit = true;
        gameObject.hideFlags = HideFlags.HideInHierarchy;
        lastPos = transform.position;
    }

    private void OnDrawGizmos()
    {
        if (!haveInit)
            Init();
        Gizmos.DrawSphere(transform.position, 1);
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.black;
        Handles.Label(transform.position + Vector3.up * 2f, title, style);
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }

    public bool HaveMove()
    {
        return lastPos != transform.position;
    }

    public void UpdatePosition()
    {
        lastPos = transform.position;
    }
}

[CustomEditor(typeof(VisualClass))]
public class VisualClassEditor : Editor
{
    private VisualClass visualClass;

    private void OnEnable()
    {
        visualClass = target as VisualClass;
    }

    public void OnSceneGUI()
    {
        Handles.PositionHandle(visualClass.transform.position, visualClass.transform.rotation);
    }
}