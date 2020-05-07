using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Dinner
{
    public partial class SequenceActionDinnerGetStayInnGil : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outTrailer_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outCamp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailure_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputPlaceIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputGilPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputNameIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputFacilityNameIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuff01Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuff02Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuff03Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuff04Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuffValue01Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuffValue02Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuffValue03Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuffValue04Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuffType01Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuffType02Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuffType03Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputBuffType04Pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDinnerGetStayInnGil();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Dinner.SequenceActionDinnerGetStayInnGil", 0, Black.Sequence.Action.Dinner.SequenceActionDinnerGetStayInnGil.ObjectType, null, properties, 0, 2040);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Dinner.SequenceActionDinnerGetStayInnGil", base.GetFieldProperties(), 234691197, -700676608);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outTrailer_", 3796696851, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outCamp_", 341474759, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outFailure_", 2395237704, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputPlaceIdPin_", 2103584299, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputGilPin_", 376278228, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputNameIdPin_", 311563138, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 736, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputFacilityNameIdPin_", 2759908891, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 824, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuff01Pin_", 3597130482, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuff02Pin_", 255641275, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1000, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuff03Pin_", 3615193900, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1088, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuff04Pin_", 2715865813, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuffValue01Pin_", 1448005473, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuffValue02Pin_", 3794117036, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuffValue03Pin_", 434564411, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuffValue04Pin_", 1577763206, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuffType01Pin_", 4078606298, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuffType02Pin_", 113000227, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuffType03Pin_", 3675750164, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputBuffType04Pin_", 4046791261, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}