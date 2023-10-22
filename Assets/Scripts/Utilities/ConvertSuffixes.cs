using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
public class ConvertSuffixes
{
    public static SuffixesInfo[] Suffixess =
    {
            new SuffixesInfo("K",3),
            new SuffixesInfo("M",6),
            new SuffixesInfo("B",9),
            new SuffixesInfo("a",12),
            new SuffixesInfo("b",15),
            new SuffixesInfo("c",18),
            new SuffixesInfo("d",21),
            new SuffixesInfo("e",24),
            new SuffixesInfo("f",27),
            new SuffixesInfo("g",30),
            new SuffixesInfo("h",33),
            new SuffixesInfo("i",36),
            new SuffixesInfo("k",39),
            new SuffixesInfo("l",42),
            new SuffixesInfo("m",45),
            new SuffixesInfo("n",48),
            new SuffixesInfo("o",51),
            new SuffixesInfo("p",54),
            new SuffixesInfo("q",57),
            new SuffixesInfo("r",60),
            new SuffixesInfo("s",63),
            new SuffixesInfo("t",66),
            new SuffixesInfo("u",69),
            new SuffixesInfo("v",72),
            new SuffixesInfo("w",75),
            new SuffixesInfo("x",78),
            new SuffixesInfo("y",81),
            new SuffixesInfo("z",84),
            new SuffixesInfo("aa",87),
            new SuffixesInfo("ab",90),
            new SuffixesInfo("ac",93),
            new SuffixesInfo("ad",96),
            new SuffixesInfo("ae",99),
            new SuffixesInfo("af",102),
            new SuffixesInfo("ag",105),
            new SuffixesInfo("ah",108),
            new SuffixesInfo("ai",111),
            new SuffixesInfo("ak",114),
            new SuffixesInfo("al",117),
            new SuffixesInfo("am",120),
            new SuffixesInfo("an",123),
            new SuffixesInfo("ao",126),
            new SuffixesInfo("ap",129),
            new SuffixesInfo("aq",132),
            new SuffixesInfo("ar",135),
            new SuffixesInfo("as",138),
            new SuffixesInfo("at",141),
            new SuffixesInfo("au",144),
            new SuffixesInfo("av",147),
            new SuffixesInfo("aw",150),
            new SuffixesInfo("ax",153),
            new SuffixesInfo("ay",156),
            new SuffixesInfo("az",159)
        };
    public static string GetConvert(long number, int tenths = 0)
    {
        string numberString = number.ToString();
        int numberLength = numberString.Length;
        if (numberLength <= Suffixess[0].zeroLength + 1) return numberString;
        else
        {
            int sufID = Suffixess.Length - 1;
            while (sufID >= 0 && Suffixess[sufID].zeroLength + 1 > numberLength)
            {
                sufID--;
            }

            string a = numberString.Substring(0, numberString.Length - Suffixess[sufID].zeroLength);
            string b = numberString.Substring(numberString.Length - Suffixess[sufID].zeroLength, tenths);
            float aa = float.Parse(a);
            float bb = float.Parse(b) / Mathf.Pow(10, tenths);
            if (tenths > 0) return (aa + bb) + Suffixess[sufID].symbol;
            else return aa + Suffixess[sufID].symbol;
        }
    }
}

public class SuffixesInfo
{
    public string symbol;
    public int zeroLength;

    public SuffixesInfo(string symbol, int zeroLength)
    {
        this.symbol = symbol;
        this.zeroLength = zeroLength;
    }
}