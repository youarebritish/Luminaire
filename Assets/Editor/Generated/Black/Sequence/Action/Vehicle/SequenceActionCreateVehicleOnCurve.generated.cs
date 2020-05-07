using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionCreateVehicleOnCurve : Black.Sequence.Actor.SequenceActionActorCreateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inCharEntryPath_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBaseActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBasePosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBaseRotate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inRange_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsFrontOfBase_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsSameLane_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin createdActor_;
		public int actorType_;
		public string charaEntry_;
		public string sourcePathAI_;
		public string sourcePathCommand_;
		public string sourcePathScheduleAI_;
		public string sourcePathScheduleDefault_;
		public float distance_;
		public float range_;
		public bool isFrontOfBase_;
		public bool isSameLane_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCreateVehicleOnCurve();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionCreateVehicleOnCurve", 0, Black.Sequence.Action.Vehicle.SequenceActionCreateVehicleOnCurve.ObjectType, null, properties, 0, 2080);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionCreateVehicleOnCurve", base.GetFieldProperties(), -1273437222, 421048229);
            
			
			
			return fieldProperties;
        }

		
    }
}