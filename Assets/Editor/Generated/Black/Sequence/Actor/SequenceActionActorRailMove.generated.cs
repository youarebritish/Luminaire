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
            
			fieldProperties.AddProperty(new Property("pathAnimGraph_", 1384086982, "Ebony.Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("sendStartMessage_0_1_", 2151284000, "bool", 456, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sendEndMessage_0_1_", 2372255181, "bool", 457, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sendCancelMessage_2_", 4276986582, "bool", 458, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("entityPointer_", 3527687820, "SQEX.Ebony.Framework.Entity.EntityGroup", 464, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			fieldProperties.AddProperty(new Property("waitTimer_", 4038233034, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("pathMovePrecision_", 1172743662, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("pathMoveSafeDistanceFactor_", 1156293387, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turningDuration_Accel_", 571306506, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turningDuration_Uniform_", 3542235794, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turningDuration_Decel_", 1338114297, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("move_speed_", 3922660873, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("faceStartPoint_", 2138318299, "bool", 500, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("doRotation_", 2559270359, "bool", 501, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("reverseMoveAxis_", 3369726926, "bool", 502, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("motionMoveAxis_", 2077867876, "Black.Sequence.Actor.SequenceActionActorRailMove.MotionMoveAxis", 504, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("padControl_", 2526301168, "bool", 508, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("padReleaseOnPathEndReached_", 226101741, "bool", 509, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useBothSidesPath_", 4181208783, "bool", 510, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useInverseMove_", 2186272062, "bool", 511, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("hasInverseMotion_", 269163144, "bool", 512, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("forwardProgressPercentage_", 3813464094, "float", 516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("backwardProgressPercentage_", 1645320984, "float", 524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 536, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("in_2_", 3991532804, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 632, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cancelIn_", 3813912853, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 728, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValue_", 2850905696, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 824, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_startPoint_", 2952177207, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 912, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_endPoint_", 1711324106, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1008, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress_startPoint_", 1324935870, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1104, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress_endPoint_", 1751183891, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1200, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveEnd_startPoint_", 1512227433, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1296, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveEnd_endPoint_", 2311507432, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1392, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finish_startPoint_", 357326626, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1488, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finish_endPoint_", 558853855, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1584, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("motionedActor_", 4094889072, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cancelOut_", 1916499030, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1768, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("nextPointPin_", 63030782, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1864, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}