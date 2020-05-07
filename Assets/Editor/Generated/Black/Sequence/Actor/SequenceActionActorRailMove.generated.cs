using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorRailMove : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string pathAnimGraph_;
		public bool sendStartMessage_0_1_;
		public bool sendEndMessage_0_1_;
		public bool sendCancelMessage_2_;
		public SQEX.Ebony.Framework.Entity.EntityGroup entityPointer_;
		public float waitTimer_;
		public float pathMovePrecision_;
		public float pathMoveSafeDistanceFactor_;
		public float turningDuration_Accel_;
		public float turningDuration_Uniform_;
		public float turningDuration_Decel_;
		public float move_speed_;
		public bool faceStartPoint_;
		public bool doRotation_;
		public bool reverseMoveAxis_;
		public int motionMoveAxis_;
		public bool padControl_;
		public bool padReleaseOnPathEndReached_;
		public bool useBothSidesPath_;
		public bool useInverseMove_;
		public bool hasInverseMotion_;
		public float forwardProgressPercentage_;
		public float backwardProgressPercentage_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancelIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_startPoint_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_endPoint_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress_startPoint_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress_endPoint_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveEnd_startPoint_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveEnd_endPoint_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_startPoint_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_endPoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin motionedActor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancelOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin nextPointPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorRailMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorRailMove", 0, Black.Sequence.Actor.SequenceActionActorRailMove.ObjectType, null, properties, 0, 1952);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorRailMove", base.GetFieldProperties(), -593448131, 632659967);
            
			
			
			return fieldProperties;
        }

		
    }
}