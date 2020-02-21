using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class GetAnimatorStateName : MonoBehaviour
{
    public string[] AnimatorStateNames;

    private Animator Animator { get; set; }

    private Dictionary<int, string> NameTable { get; set; }

    private void Start()
    {
        Animator = GetComponent<Animator>();

        BuildNameTable();
    }

    private void BuildNameTable()
    {
        NameTable = new Dictionary<int, string>();

        foreach (string stateName in AnimatorStateNames)
        {
            NameTable[Animator.StringToHash(stateName)] = stateName;
        }
    }

    public string GetCurrentAnimatorStateName()
    {
        AnimatorStateInfo stateInfo = Animator.GetCurrentAnimatorStateInfo(0);

        string stateName;
        if (NameTable.TryGetValue(stateInfo.shortNameHash, out stateName))
        {
            return stateName;
        }
        else
        {
            Debug.LogWarning("Unknown animator state name.");
            return string.Empty;
        }
    }
/*
    private void Update()
    {
        Debug.Log(GetCurrentAnimatorStateName());
    }
    */
}