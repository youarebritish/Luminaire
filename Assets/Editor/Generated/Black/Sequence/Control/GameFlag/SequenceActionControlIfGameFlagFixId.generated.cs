using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control.GameFlag
{
    public partial class SequenceActionControlIfGameFlagFixId : Black.Sequence.Control.GameFlag.SequenceActionControlGameFlagBaseFixId
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin true_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin false_;
		public int value_;
		public int operater_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlIfGameFlagFixId();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.GameFlag.SequenceActionControlIfGameFlagFixId", 0, Black.Sequence.Control.GameFlag.SequenceActionControlIfGameFlagFixId.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.GameFlag.SequenceActionControlIfGameFlagFixId", base.GetFieldProperties(), 660903000, -87704184);
            
			
			
			return fieldProperties;
        }

		
    }
}