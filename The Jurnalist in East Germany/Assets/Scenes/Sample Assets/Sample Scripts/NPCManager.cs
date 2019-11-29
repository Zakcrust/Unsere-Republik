using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface NPCManager
{
   void LayoutOn();
   void LayoutOff();
}

public interface NPCText<T>
{
    void setText(T text);
}