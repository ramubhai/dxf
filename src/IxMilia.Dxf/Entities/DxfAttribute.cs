// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Dxf.Entities
{

    /// <summary>
    /// DxfAttribute class
    /// </summary>
    public partial class DxfAttribute : DxfEntity
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.Attribute; } }

        public double Thickness { get; set; }
        public DxfPoint Location { get; set; }
        public double TextHeight { get; set; }
        public string Value { get; set; }
        public DxfVersion Version { get; set; }
        public string AttributeTag { get; set; }
        public int Flags { get; set; }
        public short FieldLength { get; set; }
        public double Rotation { get; set; }
        public double RelativeXScaleFactor { get; set; }
        public double ObliqueAngle { get; set; }
        public string TextStyleName { get; set; }
        public int TextGenerationFlags { get; set; }
        public DxfHorizontalTextJustification HorizontalTextJustification { get; set; }
        public DxfVerticalTextJustification VerticalTextJustification { get; set; }
        public DxfPoint SecondAlignmentPoint { get; set; }
        public DxfVector Normal { get; set; }
        public bool IsLockedInBlock { get; set; }
        public bool KeepDuplicateRecords { get; set; }
        public DxfMTextFlag MTextFlag { get; set; }
        public bool IsReallyLocked { get; set; }
        private int SecondaryAttributeCount { get; set; }
        public List<uint> SecondaryAttributeHandles { get; private set; }
        public DxfPoint AlignmentPoint { get; set; }
        public double AnnotationScale { get; set; }
        public string XRecordTag { get; set; }

        // Flags flags

        public bool IsInvisible
        {
            get { return DxfHelpers.GetFlag(Flags, 1); }
            set
            {
                var flags = Flags;
                DxfHelpers.SetFlag(value, ref flags, 1);
                Flags = flags;
            }
        }

        public bool IsConstant
        {
            get { return DxfHelpers.GetFlag(Flags, 2); }
            set
            {
                var flags = Flags;
                DxfHelpers.SetFlag(value, ref flags, 2);
                Flags = flags;
            }
        }

        public bool IsInputVerificationRequired
        {
            get { return DxfHelpers.GetFlag(Flags, 4); }
            set
            {
                var flags = Flags;
                DxfHelpers.SetFlag(value, ref flags, 4);
                Flags = flags;
            }
        }

        public bool IsAttributePresent
        {
            get { return DxfHelpers.GetFlag(Flags, 8); }
            set
            {
                var flags = Flags;
                DxfHelpers.SetFlag(value, ref flags, 8);
                Flags = flags;
            }
        }

        // TextGenerationFlags flags

        public bool IsTextBackward
        {
            get { return DxfHelpers.GetFlag(TextGenerationFlags, 2); }
            set
            {
                var flags = TextGenerationFlags;
                DxfHelpers.SetFlag(value, ref flags, 2);
                TextGenerationFlags = flags;
            }
        }

        public bool IsTextUpsideDown
        {
            get { return DxfHelpers.GetFlag(TextGenerationFlags, 4); }
            set
            {
                var flags = TextGenerationFlags;
                DxfHelpers.SetFlag(value, ref flags, 4);
                TextGenerationFlags = flags;
            }
        }

        public DxfAttribute()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Thickness = 0.0;
            this.Location = DxfPoint.Origin;
            this.TextHeight = 1.0;
            this.Value = null;
            this.Version = DxfVersion.R2010;
            this.AttributeTag = null;
            this.Flags = 0;
            this.FieldLength = 0;
            this.Rotation = 0;
            this.RelativeXScaleFactor = 1.0;
            this.ObliqueAngle = 0.0;
            this.TextStyleName = "STANDARD";
            this.TextGenerationFlags = 0;
            this.HorizontalTextJustification = DxfHorizontalTextJustification.Left;
            this.VerticalTextJustification = DxfVerticalTextJustification.Baseline;
            this.SecondAlignmentPoint = DxfPoint.Origin;
            this.Normal = DxfVector.ZAxis;
            this.IsLockedInBlock = false;
            this.KeepDuplicateRecords = false;
            this.MTextFlag = DxfMTextFlag.MultilineAttribute;
            this.IsReallyLocked = false;
            this.SecondaryAttributeCount = 0;
            this.SecondaryAttributeHandles = new List<uint>();
            this.AlignmentPoint = DxfPoint.Origin;
            this.AnnotationScale = 1.0;
            this.XRecordTag = null;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(100, "AcDbText"));
            }
            if (this.Thickness != 0.0)
            {
                pairs.Add(new DxfCodePair(39, (this.Thickness)));
            }

            pairs.Add(new DxfCodePair(10, Location?.X ?? default(double)));
            pairs.Add(new DxfCodePair(20, Location?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(30, Location?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(40, (this.TextHeight)));
            pairs.Add(new DxfCodePair(1, (this.Value)));
            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(100, "AcDbAttribute"));
            }
            if (version >= DxfAcadVersion.R2010)
            {
                pairs.Add(new DxfCodePair(280, (short)(this.Version)));
            }

            pairs.Add(new DxfCodePair(2, (this.AttributeTag)));
            pairs.Add(new DxfCodePair(70, (short)(this.Flags)));
            if (this.FieldLength != 0)
            {
                pairs.Add(new DxfCodePair(73, (this.FieldLength)));
            }

            if (this.Rotation != 0)
            {
                pairs.Add(new DxfCodePair(50, (this.Rotation)));
            }

            if (this.RelativeXScaleFactor != 1.0)
            {
                pairs.Add(new DxfCodePair(41, (this.RelativeXScaleFactor)));
            }

            if (this.ObliqueAngle != 0.0)
            {
                pairs.Add(new DxfCodePair(51, (this.ObliqueAngle)));
            }

            if (this.TextStyleName != "STANDARD")
            {
                pairs.Add(new DxfCodePair(7, (this.TextStyleName)));
            }

            if (this.TextGenerationFlags != 0)
            {
                pairs.Add(new DxfCodePair(71, (short)(this.TextGenerationFlags)));
            }

            if (this.HorizontalTextJustification != DxfHorizontalTextJustification.Left)
            {
                pairs.Add(new DxfCodePair(72, (short)(this.HorizontalTextJustification)));
            }

            if (version >= DxfAcadVersion.R12 && this.VerticalTextJustification != DxfVerticalTextJustification.Baseline)
            {
                pairs.Add(new DxfCodePair(74, (short)(this.VerticalTextJustification)));
            }

            pairs.Add(new DxfCodePair(11, SecondAlignmentPoint?.X ?? default(double)));
            pairs.Add(new DxfCodePair(21, SecondAlignmentPoint?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(31, SecondAlignmentPoint?.Z ?? default(double)));
            if (this.Normal != DxfVector.ZAxis)
            {
                pairs.Add(new DxfCodePair(210, Normal?.X ?? default(double)));
                pairs.Add(new DxfCodePair(220, Normal?.Y ?? default(double)));
                pairs.Add(new DxfCodePair(230, Normal?.Z ?? default(double)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(280, BoolShort(this.IsLockedInBlock)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(100, "AcDbXrecord"));
            }
            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(280, BoolShort(this.KeepDuplicateRecords)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(70, (short)(this.MTextFlag)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(70, BoolShort(this.IsReallyLocked)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(70, (short?)SecondaryAttributeHandles?.Count ?? default(short)));
            }
            if (version >= DxfAcadVersion.R2007)
            {
                pairs.AddRange(this.SecondaryAttributeHandles.Select(p => new DxfCodePair(340, p)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(10, AlignmentPoint?.X ?? default(double)));
                pairs.Add(new DxfCodePair(20, AlignmentPoint?.Y ?? default(double)));
                pairs.Add(new DxfCodePair(30, AlignmentPoint?.Z ?? default(double)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(40, (this.AnnotationScale)));
            }

            if (version >= DxfAcadVersion.R2007)
            {
                pairs.Add(new DxfCodePair(2, (this.XRecordTag)));
            }

        }
    }

}
