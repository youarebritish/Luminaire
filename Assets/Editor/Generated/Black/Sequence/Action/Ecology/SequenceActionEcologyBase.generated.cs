using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionEcologyBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int prefixType_;
		public uint id_;
		public uint teamId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEcologyBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionEcologyBase", 0, Black.Sequence.Action.Ecology.SequenceActionEcologyBase.ObjectType, null, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionEcologyBase", base.GetFieldProperties(), 1297533890, 1366532009);
            return fieldProperties;
        }

		
    }
}