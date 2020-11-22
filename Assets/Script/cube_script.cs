using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class cube_script : MonoBehaviour
{
    [SerializeField]
    private int id;
    [SerializeField]
    private string name;

    [SerializeField]
    private GameObject[] gameObjects;






    private void Reset()
    {
        Debug.Log("cube_script --- Reset");

    }





    private void Awake()
    {
        Debug.Log("cube_script --- Awake");
    }

    private void OnEnable()
    {
        Debug.Log("cube_script --- OnEnable");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("cube_script --- Start");

        
    }
    private Coroutine m_Coroutine = null;

    private void OnGUI()
    {
        if (GUILayout.Button("Start"))
        {
            if (m_Coroutine != null)
            {
                StopCoroutine(m_Coroutine);
            }
            m_Coroutine = StartCoroutine(reateCube());
        }

        if (GUILayout.Button("Stop"))
        {
            if (m_Coroutine != null)
            {
                StopCoroutine(m_Coroutine);
            }
        }

        if (GUILayout.Button("Global"))
        {
            Global.instance.doSomeThings();
        }

    }


    IEnumerator reateCube()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = Vector3.one * i;
            yield return new WaitForSeconds(1f);
    }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("cube_script --- Update");
    }

    private void OnDisable()
    {
        Debug.Log("cube_script --- OnDisable");
    }

    private void OnMouseDown()
    {
        Debug.Log("cube_script --- OnMouseDown");
    }

    private void OnMouseDrag()
    {
        Debug.Log("cube_script --- OnMouseDrag");
    }

    private void OnMouseOver()
    {
        //Debug.Log("cube_script --- OnMouseOver");
    }

    private void OnMouseUp()
    {
        Debug.Log("cube_script --- OnMouseUp");
    }


    private void OnMouseEnter()
    {
        //Debug.Log("cube_script --- OnMouseEnter");

    }
    private void OnMouseExit()
    {
        //Debug.Log("cube_script --- OnMouseExit");
    }


}

#if UNITY_EDITOR
[CustomEditor(typeof(cube_script))]
public class ScriptInsector:Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        SerializedProperty property = serializedObject.FindProperty("id");
        property.intValue = EditorGUILayout.IntField("主键", property.intValue);
        EditorGUI.BeginChangeCheck();
        EditorGUILayout.PropertyField(serializedObject.FindProperty("name"), true);
        if (EditorGUI.EndChangeCheck())
        {
            Debug.Log("name发生改变");
        }


        EditorGUI.BeginChangeCheck();
        EditorGUILayout.PropertyField(serializedObject.FindProperty("gameObjects"), true);
        if (EditorGUI.EndChangeCheck())
        {
            Debug.Log("元素发生改变");
        }

        serializedObject.ApplyModifiedProperties();
    }
} 
#endif


