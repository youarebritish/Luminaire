using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionVehicleScoreRecord : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin set_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin scoreOut3_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin scoreOut2_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin scoreOut1_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin newScoreRankOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin scoreIn_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionVehicleScoreRecord();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionVehicleScoreRecord", 0, Black.Sequence.Action.Vehicle.SequenceActionVehicleScoreRecord.ObjectType, null, properties, 0, 824);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionVehicleScoreRecord", base.GetFieldProperties(), 153269951, -800567244);
            
			
			
			return fieldProperties;
        }

		
    }
}