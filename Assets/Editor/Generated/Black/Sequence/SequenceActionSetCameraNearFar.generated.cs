using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence
{
    public partial class SequenceActionSetCameraNearFar : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float near_;
		public float far_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetCameraNearFar();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.SequenceActionSetCameraNearFar", 0, Black.Sequence.SequenceActionSetCameraNearFar.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.SequenceActionSetCameraNearFar", base.GetFieldProperties(), 1838439964, 2083033206);
            return fieldProperties;
        }

		
    }
}