﻿using Luminous.Core.Object;
using System.Collections.Generic;

namespace Ebony.Framework.Sequence
{
    public class SequenceAction : SequenceActivatableNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;

        public bool Isolated_ { get; set; }

        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceAction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.SequenceAction", 0, SequenceActivatableNode.ObjectType, Construct, properties, 1, 88);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.SequenceAction", base.GetFieldProperties(), 1106888044, -729667281);
            fieldProperties.AddProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new SequenceAction();
        }
    }
}