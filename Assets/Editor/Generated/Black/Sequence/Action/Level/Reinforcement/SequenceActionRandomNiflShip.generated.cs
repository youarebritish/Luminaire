using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Reinforcement
{
    public partial class SequenceActionRandomNiflShip : Black.Sequence.Action.Level.Reinforcement.SequenceActionPopNiflShip
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin memory_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shouldResetTeam_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forceStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forceTeamArrangement_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin forceTeamIdx_;
		public int farWaitTime_;
		public int nearWaitTime_;
		public float farDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionRandomNiflShip();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Reinforcement.SequenceActionRandomNiflShip", 0, Black.Sequence.Action.Level.Reinforcement.SequenceActionRandomNiflShip.ObjectType, null, properties, 0, 3456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Reinforcement.SequenceActionRandomNiflShip", base.GetFieldProperties(), -1952085699, 1117718072);
            
			fieldProperties.AddProperty(new Property("finished_", 3052293812, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2744, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("memory_", 759684707, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2840, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shouldResetTeam_", 122222145, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2928, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceStart_", 218268117, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 3016, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceTeamArrangement_", 2938275196, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 3112, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceTeamIdx_", 1042476053, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3208, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("farWaitTime_", 394555935, "int", 3296, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("nearWaitTime_", 2654744688, "int", 3300, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("farDistance_", 928478302, "float", 3304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}