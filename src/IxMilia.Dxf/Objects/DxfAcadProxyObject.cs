// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Dxf.Objects
{

    public class DxfAcadProxyObject : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.AcadProxyObject; } }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                //case 5:
                //    this.Handle = pair.StringValue;
                //    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }
}
