﻿
using UnityEngine;

public class soilder
{
    public int Exp;
        public int LV;

    public int GetExp()
    {
        Exp = LV * 20;
        return Exp;
    }

    public void SetExp(int getExp)
    {
        Exp = getExp;
    }
}