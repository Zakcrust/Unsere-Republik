using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface NPCManager
{
   void OnTrigger();
   void OffTrigger();
   void ButtonOn();
}

public interface NPCText<T>
{
    void setText(T text);
    void setPositiveText(T text);
    void setNegativeText(T text);
}