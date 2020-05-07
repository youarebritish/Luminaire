﻿using Ebony.Framework.Node;
using Luminous.Core.Object;
using System.Collections.Generic;

namespace Ebony.Framework.Sequence
{
    public class SequenceActivatableNode : SequenceNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;

        public List<GraphPin> triInPorts_ { get; set; } = new List<GraphPin>();
        public List<GraphPin> triOutPorts_ { get; set; } = new List<GraphPin>();

        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActivatableNode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.SequenceActivatableNode", 0, SequenceNode.ObjectType, Construct, properties, 1, 88);
        }

        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.SequenceActivatableNode", base.GetFieldProperties(), 1106888044, -729667281);
            fieldProperties.AddProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
            fieldProperties.AddProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new SequenceActivatableNode();
        }
    }
}