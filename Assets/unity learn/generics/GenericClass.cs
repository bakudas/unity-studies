using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass <T>
{
    public T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}

