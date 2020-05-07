using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Physics
{
    public partial class SequenceActionActorBonamikLocalForceScale : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin autoResetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupsPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorsPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float scale_;
		public int blendedFrames;
		public int selectGroup_;
		public bool bAutoReset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBonamikLocalForceScale();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikLocalForceScale", 0, Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikLocalForceScale.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikLocalForceScale", base.GetFieldProperties(), -1440814070, -2024669374);
            
			
			
			return fieldProperties;
        }

		
    }
}