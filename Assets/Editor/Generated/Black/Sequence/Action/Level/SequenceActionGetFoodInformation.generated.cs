using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetFoodInformation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foodIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin foodPathPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin pricePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin countIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin shopNameIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin additionalCampFoodPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin foodNameIdPin_;
		public uint foodId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetFoodInformation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetFoodInformation", 0, Black.Sequence.Action.Level.SequenceActionGetFoodInformation.ObjectType, null, properties, 0, 992);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetFoodInformation", base.GetFieldProperties(), -1456557207, 69783894);
            
			
			
			return fieldProperties;
        }

		
    }
}