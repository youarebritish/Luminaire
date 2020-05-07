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
            
			
			
			return fieldProperties;
        }

		
    }
}