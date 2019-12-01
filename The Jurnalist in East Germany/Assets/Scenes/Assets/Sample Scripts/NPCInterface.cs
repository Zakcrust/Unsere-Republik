using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface NPCInterface
{
    void OnTrigger();
}

public interface NPCText<T>
{
    void setText(T text);
    IEnumerator iterateText(T text);
}