using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(AlphabetData))]
[CanEditMultipleObjects]
[System.Serializable]

public class AlphabetDataDrawer : Editor
{
    private ReorderableList alphabetPlainList;
    private ReorderableList alphabetNormal;
    private ReorderableList alphabetHighlightedList;
    private ReorderableList alphabetWrongList;

    private void OnEnable()
    {
        initializeReorderableList(ref alphabetPlainList, "alphabetPlain", "Alphabet Plain");
        initializeReorderableList(ref alphabetNormal, "alphabetNormal", "Alphabet Normal");
        initializeReorderableList(ref alphabetHighlightedList, "alphabetHighlighted", "Alphabet Highlighted");
        initializeReorderableList(ref alphabetWrongList, "alphabetWrong", "Alphabet Wrong");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        alphabetPlainList.DoLayoutList();
        alphabetNormal.DoLayoutList();
        alphabetHighlightedList.DoLayoutList();
        alphabetWrongList.DoLayoutList();
        serializedObject.ApplyModifiedProperties();
    }

    private void initializeReorderableList(ref ReorderableList list, string propertyName, string listLabel)
    {
        list = new ReorderableList(serializedObject, serializedObject.FindProperty(propertyName), true,
            true, true, true);

        list.drawHeaderCallback = (Rect rect) =>
        {
            EditorGUI.LabelField(rect, listLabel);
        };

        var l = list;

        list.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
        {
            var element = l.serializedProperty.GetArrayElementAtIndex(index);
            rect.y += 2;
            EditorGUI.PropertyField(new Rect(rect.x, rect.y, 60, EditorGUIUtility.singleLineHeight),
                element.FindPropertyRelative("letter"), GUIContent.none);

            EditorGUI.PropertyField(new Rect(rect.x + 70, rect.y, rect.width - 90, EditorGUIUtility.singleLineHeight),
                element.FindPropertyRelative("image"), GUIContent.none);
        };
    }

}
