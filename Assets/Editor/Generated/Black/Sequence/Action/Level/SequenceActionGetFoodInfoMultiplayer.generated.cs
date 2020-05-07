using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetFoodInfoMultiplayer : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foodIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin foodPathPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin lightingPathPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin foodNameIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin foodRotationPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin luncheonPathPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin foodRankPin_;
		public uint foodId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetFoodInfoMultiplayer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetFoodInfoMultiplayer", 0, Black.Sequence.Action.Level.SequenceActionGetFoodInfoMultiplayer.ObjectType, null, properties, 0, 992);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetFoodInfoMultiplayer", base.GetFieldProperties(), 826461155, 62283636);
            return fieldProperties;
        }

		
    }
}