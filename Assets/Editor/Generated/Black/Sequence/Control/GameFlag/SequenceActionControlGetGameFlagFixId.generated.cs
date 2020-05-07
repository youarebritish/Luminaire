using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control.GameFlag
{
    public partial class SequenceActionControlGetGameFlagFixId : Black.Sequence.Control.GameFlag.SequenceActionControlGameFlagBaseFixId
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePin_;
		public bool isFixid_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlGetGameFlagFixId();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.GameFlag.SequenceActionControlGetGameFlagFixId", 0, Black.Sequence.Control.GameFlag.SequenceActionControlGetGameFlagFixId.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.GameFlag.SequenceActionControlGetGameFlagFixId", base.GetFieldProperties(), 510201147, 502959535);
            
			
			
			return fieldProperties;
        }

		
    }
}