using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control.GameFlag
{
    public partial class SequenceActionControlAddGameFlagFixId : Black.Sequence.Control.GameFlag.SequenceActionControlGameFlagBaseFixId
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valuePin_;
		public int value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlAddGameFlagFixId();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.GameFlag.SequenceActionControlAddGameFlagFixId", 0, Black.Sequence.Control.GameFlag.SequenceActionControlAddGameFlagFixId.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.GameFlag.SequenceActionControlAddGameFlagFixId", base.GetFieldProperties(), 322796813, 1497152338);
            
			
			
			return fieldProperties;
        }

		
    }
}