﻿using System;
using System.Runtime.InteropServices;


using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace SimpleScene
{
    ///////////////////////////////////////////////////////

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SSAttributePos : ISSAttributeLayout, IEquatable<SSAttributePos>
    {
        public Vector3 Position;

        public SSAttributePos(Vector3 pos) 
        {
            Position = pos;
        }

        public VertexAttribPointerType AttributeType() { return VertexAttribPointerType.Float; }

        public int NumComponents() { return 3; }

        public bool IsNormalized() { return false; }

        public bool Equals(SSAttributePos other)
        {
            return this.Position == other.Position;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SSAttributeColor : ISSAttributeLayout, IEquatable<SSAttributeColor>
    {
        public int Color;

        public SSAttributeColor(int color) {
            Color = color;
        }

        public VertexAttribPointerType AttributeType() { return VertexAttribPointerType.UnsignedByte; }

        public int NumComponents() { return 4; }

        public bool IsNormalized() { return true; }

        public bool Equals (SSAttributeColor other)
        {
            return this.Color == other.Color;
        }
    }
}

