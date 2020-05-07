using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control.GameFlag
{
    public partial class SequenceActionControlSetGameFlagFixId : Black.Sequence.Control.GameFlag.SequenceActionControlGameFlagBaseFixId
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPin_;
		public int value_;
		public bool isFixid_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlSetGameFlagFixId();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.GameFlag.SequenceActionControlSetGameFlagFixId", 0, Black.Sequence.Control.GameFlag.SequenceActionControlSetGameFlagFixId.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.GameFlag.SequenceActionControlSetGameFlagFixId", base.GetFieldProperties(), -562753497, -679724828);
            return fieldProperties;
        }

		
    }
}