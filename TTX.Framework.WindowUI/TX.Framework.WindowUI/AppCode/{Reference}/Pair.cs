﻿#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2011
//
//     COPYRIGHT (C) 2011, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace System
{
    [Serializable, StructLayout(LayoutKind.Sequential), DebuggerDisplay("{First}, {Second}")]
    public struct Pair<TFirst, TSecond> : IEquatable<Pair<TFirst, TSecond>>
    {
        public readonly TFirst First;
        public readonly TSecond Second;

        public Pair(TFirst first, TSecond second)
        {
            this.First = first;
            this.Second = second;
        }

        public static bool operator ==(Pair<TFirst, TSecond> left, Pair<TFirst, TSecond> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Pair<TFirst, TSecond> left, Pair<TFirst, TSecond> right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", this.First, this.Second);
        }

        public override int GetHashCode()
        {
            int num = (this.First != null) ? this.First.GetHashCode() : 0;
            return ((num * 397) ^ ((this.Second != null) ? this.Second.GetHashCode() : 0));
        }

        public bool Equals(Pair<TFirst, TSecond> other)
        {
            return this.First.Equals(other);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Pair<TFirst, TSecond>))
            {
                return false;
            }
            return this.Equals((Pair<TFirst, TSecond>)obj);
        }
    }
}
