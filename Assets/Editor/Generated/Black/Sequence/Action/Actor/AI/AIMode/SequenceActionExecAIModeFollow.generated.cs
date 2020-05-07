using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeFollow : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin walkSpeedRatePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin runSpeedRatePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public int movementNearTarget_;
		public float walkSpeedRate_;
		public int movementFarTarget_;
		public float runSpeedRate_;
		public float arrivalInnerDistance_;
		public float arrivalOuterDistance_;
		public float walkingAreaRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeFollow();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeFollow", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeFollow.ObjectType, null, properties, 0, 1584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeFollow", base.GetFieldProperties(), -1017410623, 1992179424);
            
			
			
			return fieldProperties;
        }

		
    }
}