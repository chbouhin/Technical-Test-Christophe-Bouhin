﻿using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

namespace technical.test.editor
{
    [CreateAssetMenu(fileName = "Scene Gizmo Asset", menuName = "Custom/Create Scene Gizmo Asset")]
    public class SceneGizmoAsset : ScriptableObject
    {
        [SerializeField] private Gizmo[] _gizmos = default;

        public override string ToString()
        {
            return "Gizmo count : " + _gizmos.Length;
        }

        public Gizmo[] GetGizmos()
        {
            return _gizmos;
        }
    }

}