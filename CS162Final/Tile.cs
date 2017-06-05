﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace nullEngine
{
    //this is a struct for each tile
    public class Tile
    {
        public int TexID;
        public TextureAtlas tAtlas;
    }
    
    //this is an enum for all of the letters supported by /Content/font.png
    public enum letter
    {
        space = 0,
        exclaim = 1,
        double_quote = 2,
        hash = 3,
        dollar = 4,
        percent = 5,
        ampersand = 6,
        single_quote = 7,
        open_paren = 8,
        close_paren = 9,
        star = 10,
        plus = 11,
        comma = 12,
        dash = 13,
        period = 14,
        forward_slash = 15,
        zero = 16,
        one = 17,
        two = 18,
        three = 19,
        four = 20,
        five = 21,
        six = 22, 
        seven = 23,
        eight = 24,
        nine = 25,
        colon = 26,
        semicolon = 27,
        less_than = 28,
        equals = 29,
        greater_than = 30,
        question = 31,
        at = 32,
        A = 33,
        B = 34,
        C = 35,
        D = 36,
        E = 37,
        F = 38,
        G = 39,
        H = 40,
        I = 41,
        J = 42, 
        K = 43,
        L = 44,
        M = 45,
        N = 46,
        O = 47,
        P = 48,
        Q = 49,
        R = 50,
        S = 51,
        T = 52,
        U = 53,
        V = 54,
        W = 55,
        X = 56,
        Y = 57,
        Z = 58,
        open_bracket = 59,
        back_slash = 60,
        close_bracket = 61,
        carat = 62,
        underscore = 63,
        tick = 64,
        a = 65,
        b = 66,
        c = 67,
        d = 68,
        e = 69,
        f = 70,
        g = 71,
        h = 72,
        i = 73,
        j = 74,
        k = 75,
        l = 76,
        m = 77,
        n = 78,
        o = 79,
        p = 80,
        q = 81,
        r = 82,
        s = 83,
        t = 84,
        u = 85,
        v = 86,
        w = 87,
        x = 88,
        y = 89,
        z = 90,
        open_brace = 91,
        pipe = 92,
        close_brace = 93,
        tilde = 94,
        empty = 95
    }
}
