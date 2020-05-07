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
            
			fieldProperties.AddProperty(new Property("startSimPin_", 1294034958, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopSimPin_", 3631840148, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pauseSimPin_", 2978561724, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resetSimPin_", 2395232083, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("preRollPin_", 3865747925, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnAnimBlendPin_", 2425811133, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffAnimBlendPin_", 2688168505, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 760, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("changeLocalForceParamsPin_", 3286972869, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 856, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnGroundPin_", 2668560428, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 952, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffGroundPin_", 4174190216, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1048, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnWindPin_", 1402661009, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1144, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffWindPin_", 164857661, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1240, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnConePin_", 2820045364, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1336, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffConePin_", 2206153296, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1432, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnSphereConstraintPin_", 3260054225, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1528, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffSphereConstraintPin_", 1130127933, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1624, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setGravityPin_", 859585687, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1720, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnKinematicPin_", 4160925748, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1816, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffKinematicPin_", 2476999392, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1912, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setEmissiveWindPin_", 952513414, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2008, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setDampingScalePin_", 463985187, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2104, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setInnerConeScalePin_", 2673966376, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2200, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setOuterConeScalePin_", 2252916901, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2296, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setLocalForceScalePin_", 1601672873, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2392, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOnConeAnimationPin_", 2207187506, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2488, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnOffConeAnimationPin_", 3247098030, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2584, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("setAddMassPin_", 1346385566, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2680, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reinitializePosePin_", 3287745847, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2776, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("restoreParameterPin_", 3006633012, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2872, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorsPin_", 3366497575, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 3056, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ResetPose_", 3696248214, "bool", 3152, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("animationBlendCoeff_", 2096144374, "float", 3156, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("preRollStep_", 2689838500, "int", 3160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendedFrames_", 1011153196, "int", 3164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("gravity_", 3216807406, "Luminous.Math.VectorA", 3168, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectGroup_", 307161457, "Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikControl.eBONAMIKSELECTGROUP", 3184, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("addMass_", 4288545305, "float", 3188, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("dampingScale_", 1718241498, "float", 3192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("innerConeScale_", 646225783, "float", 3196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("outerConeScale_", 2935093024, "float", 3200, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("localForceScale_", 26593156, "float", 3204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("LocalForceOverallScale_", 2076223703, "float", 3208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("LocalForceCoeff_", 1453812889, "float", 3212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("DynamicParkRate_", 1732236129, "float", 3216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("MaxLocalTranslate_", 3118428567, "float", 3220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWindStr_", 1501641732, "float", 3224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWindWaveAmplitude_", 3104106559, "float", 3228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("emissiveWindWaveTime_", 665416441, "float", 3232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}