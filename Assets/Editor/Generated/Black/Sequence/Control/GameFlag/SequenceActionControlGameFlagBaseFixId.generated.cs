using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control.GameFlag
{
    public partial class SequenceActionControlGameFlagBaseFixId : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public uint label_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlGameFlagBaseFixId();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.GameFlag.SequenceActionControlGameFlagBaseFixId", 0, Black.Sequence.Control.GameFlag.SequenceActionControlGameFlagBaseFixId.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.GameFlag.SequenceActionControlGameFlagBaseFixId", base.GetFieldProperties(), -466787544, 1753461124);
            return fieldProperties;
        }

		
    }
}