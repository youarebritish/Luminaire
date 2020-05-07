using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorSetTransform : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin layCheckNG_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rayCheckSuccess_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotationOffset_;
		public bool entityGroupFlag_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActorPin_;
		public bool isTeleportCamera_;
		public int affectRotTypeForTargetActorPin_;
		public bool isUseRayCheck_;
		public bool isForceCreateActor_EvenRayCheckNG_;
		public float upperRayOffset;
		public float lowerRayOffset;
		public bool bRayCastShiftBlockCollision_;
		public bool isRaycastBGOnly_;
		public bool waitCollisionAfterSetTrans_;
		public bool isAffectRotYTargetActorPin_;
		public bool isWorldRotationOffset_;
		public bool isMoveToTargetActorScene_;
		public bool rotatePositionOffsetWithTargetActorRotation;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetTransform();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorSetTransform", 0, Black.Sequence.Action.Actor.SequenceActionActorSetTransform.ObjectType, null, properties, 0, 1168);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorSetTransform", base.GetFieldProperties(), -1475992531, 1362493431);
            return fieldProperties;
        }

		
    }
}