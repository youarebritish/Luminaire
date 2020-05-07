using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeRoute : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin speedRatePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inRouteIdPin_;
		public uint routeId_;
		public int activateMode_;
		public int movement_;
		public float speedRate_;
		public float timeout_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeRoute();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeRoute", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeRoute.ObjectType, null, properties, 0, 1448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeRoute", base.GetFieldProperties(), 1852877522, 1315761486);
            
			
			
			return fieldProperties;
        }

		
    }
}