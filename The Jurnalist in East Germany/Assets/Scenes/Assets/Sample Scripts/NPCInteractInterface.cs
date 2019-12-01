using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface NPCInteractInterface
{
   void OnTrigger();
   void OffTrigger();
   void ButtonOn();
}

public interface NPCInteractText<T>
{
    void setText(T text);
    void setPositiveText(T text);
    void setNegativeText(T text);
    IEnumerator iterateText(T text);
}