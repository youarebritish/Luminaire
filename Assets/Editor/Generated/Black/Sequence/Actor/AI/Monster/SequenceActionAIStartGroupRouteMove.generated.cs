using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Monster
{
    public partial class SequenceActionAIStartGroupRouteMove : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public uint routeID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin team_;
		public bool endByDamage_;
		public bool endByEncountGauge_;
		public float moveSpeed_;
		public float groupRadius_;
		public float distanceFromNeighbor_;
		public float arrivalRadius_;
		public bool isUsingAdvancedSetting_;
		public uint overrideSteeringConfigID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIStartGroupRouteMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Monster.SequenceActionAIStartGroupRouteMove", 0, Black.Sequence.Actor.AI.Monster.SequenceActionAIStartGroupRouteMove.ObjectType, null, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Monster.SequenceActionAIStartGroupRouteMove", base.GetFieldProperties(), 590524373, -1947872739);
            return fieldProperties;
        }

		
    }
}