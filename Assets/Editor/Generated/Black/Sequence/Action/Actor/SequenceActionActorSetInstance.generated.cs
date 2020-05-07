using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorSetInstance : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enableCls_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disableCls_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin list_;
		public int instanceNum_;
		public bool isUseRayCheck_;
		public bool isForceCreateActor_EvenRayCheckNG_;
		public bool useCollision_;
		public float upperRayOffset;
		public float lowerRayOffset;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnPointPin_;
		public int limitInFrame_;
		public int maxFrame_;
		public float space_;
		public float groupSpace_;
		public float clsHeight_;
		public float clsRadius_;
		public bool isSpawnRotate_;
		public bool isCheckCameraPosition_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetInstance();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorSetInstance", 0, Black.Sequence.Action.Actor.SequenceActionActorSetInstance.ObjectType, null, properties, 0, 1232);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorSetInstance", base.GetFieldProperties(), 999544883, -840691938);
            return fieldProperties;
        }

		
    }
}