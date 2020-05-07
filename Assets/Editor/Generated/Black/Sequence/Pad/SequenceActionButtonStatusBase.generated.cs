using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Pad
{
    public partial class SequenceActionButtonStatusBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionButtonStatusBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Pad.SequenceActionButtonStatusBase", 0, Black.Sequence.Pad.SequenceActionButtonStatusBase.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Pad.SequenceActionButtonStatusBase", base.GetFieldProperties(), -953247538, -358203213);
            return fieldProperties;
        }

		
    }
}