using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Physics
{
    public partial class SequenceActionActorBonamikControl : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startSimPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopSimPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pauseSimPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin resetSimPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin preRollPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnAnimBlendPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffAnimBlendPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin changeLocalForceParamsPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnGroundPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffGroundPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnWindPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffWindPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnConePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffConePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnSphereConstraintPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffSphereConstraintPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setGravityPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnKinematicPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffKinematicPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setEmissiveWindPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setDampingScalePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setInnerConeScalePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setOuterConeScalePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setLocalForceScalePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOnConeAnimationPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin turnOffConeAnimationPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setAddMassPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reinitializePosePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin restoreParameterPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorsPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool ResetPose_;
		public float animationBlendCoeff_;
		public int preRollStep_;
		public int blendedFrames_;
		public UnityEngine.Vector4 gravity_;
		public int selectGroup_;
		public float addMass_;
		public float dampingScale_;
		public float innerConeScale_;
		public float outerConeScale_;
		public float localForceScale_;
		public float LocalForceOverallScale_;
		public float LocalForceCoeff_;
		public float DynamicParkRate_;
		public float MaxLocalTranslate_;
		public float emissiveWindStr_;
		public float emissiveWindWaveAmplitude_;
		public float emissiveWindWaveTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBonamikControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl", 0, Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl.ObjectType, null, properties, 0, 3248);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl", base.GetFieldProperties(), -1248098145, 813145794);
            
			
			
			return fieldProperties;
        }

		
    }
}