using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetLensFilter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public float centerX_;
		public float centerY_;
		public float screenScale_;
		public float lensScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_lensScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_screenScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_centerY_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_centerX_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_enabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetLensFilter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetLensFilter", 0, Black.Sequence.ScreenEffect.SequenceActionSetLensFilter.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetLensFilter", base.GetFieldProperties(), 465790916, -870564998);
            return fieldProperties;
        }

		
    }
}