using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Light
{
    public partial class SequenceActionLightBounce : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin outActor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueHitPosition_;
		public float rayUpdate_;
		public float rayDistance_;
		public bool rayMovePosition_;
		public float rayHeightOffset_;
		public float rayIntensity_;
		public float rayIntensitySpeed_;
		public float rayDistanceIntensity_;
		public float rayHitPositionIntensity_;
		public float bouncePosRate_;
		public float directPosRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionLightBounce();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Light.SequenceActionLightBounce", 0, Black.Sequence.Action.Light.SequenceActionLightBounce.ObjectType, null, properties, 0, 864);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Light.SequenceActionLightBounce", base.GetFieldProperties(), -517340037, 197658324);
            
			
			
			return fieldProperties;
        }

		
    }
}