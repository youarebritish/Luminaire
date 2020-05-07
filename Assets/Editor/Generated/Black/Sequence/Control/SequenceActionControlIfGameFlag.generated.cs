using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control
{
    public partial class SequenceActionControlIfGameFlag : Black.Sequence.Control.SequenceActionControlGameFlagBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valuePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin true_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin false_;
		public int operater_;
		public int value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlIfGameFlag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.SequenceActionControlIfGameFlag", 0, Black.Sequence.Control.SequenceActionControlIfGameFlag.ObjectType, null, properties, 0, 696);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.SequenceActionControlIfGameFlag", base.GetFieldProperties(), 1396805891, -1941377570);
            return fieldProperties;
        }

		
    }
}