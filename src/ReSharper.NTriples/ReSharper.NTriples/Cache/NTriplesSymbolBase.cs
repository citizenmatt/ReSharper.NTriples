﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   NTriplesSymbolBase.cs
// </summary>
// ***********************************************************************

using System.IO;
using JetBrains.ReSharper.Psi;

namespace ReSharper.NTriples.Cache
{
    public abstract class NTriplesSymbolBase : INTriplesSymbol
    {
        protected NTriplesSymbolBase(string name, int offset, IPsiSourceFile sourceFile)
        {
            this.Name = name;
            this.Offset = offset;
            this.SourceFile = sourceFile;
        }

        protected NTriplesSymbolBase()
        {
        }

        public string Name { get; private set; }
        public int Offset { get; private set; }
        public IPsiSourceFile SourceFile { get; private set; }

        public virtual void Read(BinaryReader reader)
        {
            this.Name = reader.ReadString();
            this.Offset = reader.ReadInt32();
        }

        public void SetSourceFile(IPsiSourceFile sourceFile)
        {
            this.SourceFile = sourceFile;
        }

        public virtual void Write(BinaryWriter writer)
        {
            writer.Write(this.Name);
            writer.Write(this.Offset);
        }
    }
}
