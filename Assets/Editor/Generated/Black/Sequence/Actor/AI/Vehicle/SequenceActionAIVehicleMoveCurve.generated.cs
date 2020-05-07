using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIVehicleMoveCurve : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inTarget_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin arrivalRangePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timeoutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public UnityEngine.Vector4 targetPos_;
		public float arrivalRange_;
		public float timeout_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIVehicleMoveCurve();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleMoveCurve", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleMoveCurve.ObjectType, null, properties, 0, 992);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleMoveCurve", base.GetFieldProperties(), 1880233177, 70230451);
            
			
			
			return fieldProperties;
        }

		
    }
}