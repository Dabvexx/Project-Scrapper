using UnityEngine;
using UnityEditor;
using Sirenix.OdinInspector.Editor;

///<summary>
/// 
///</summary>
[CustomEditor(typeof(GridItem))]
public class GridItemEditor : OdinEditor
{
	//private SerializedProperty gridProperty;

	//private void OnEnable()
	//{
	//	gridProperty = serializedObject.FindProperty("grid");
	//}

 //   public override void OnInspectorGUI()
 //   {
 //       serializedObject.Update();

 //       DrawDefaultInspector();

 //       EditorGUILayout.Space();

 //       EditorGUILayout.LabelField("Grid:");

 //       gridProperty.arraySize = EditorGUILayout.IntField("Rows", gridProperty.arraySize);
 //       for (int i = 0; i < gridProperty.arraySize; i++)
 //       {
 //           var row = gridProperty.GetArrayElementAtIndex(i);
 //           row.arraySize = EditorGUILayout.IntField("Columns", row.arraySize);
 //       }

 //       EditorGUILayout.Space();

 //       // Draw the table matrix
 //       EditorGUI.BeginChangeCheck();
 //       EditorGUILayout.PropertyField(gridProperty);
 //       if (EditorGUI.EndChangeCheck())
 //       {
 //           serializedObject.ApplyModifiedProperties();
 //       }

 //       serializedObject.ApplyModifiedProperties();
 //   }

}