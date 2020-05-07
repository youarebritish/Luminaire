using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Pad
{
    public partial class SequenceActionStickMask : Black.Sequence.Pad.SequenceActionButtonStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int stickProperty_;
		public bool flag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionStickMask();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Pad.SequenceActionStickMask", 0, Black.Sequence.Pad.SequenceActionStickMask.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Pad.SequenceActionStickMask", base.GetFieldProperties(), -1496629379, -684365579);
            return fieldProperties;
        }

		
    }
}