using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Reinforcement
{
    public partial class SequenceActionPopReinforcement : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inGenerator_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEncountTrigger;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPopPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outReinforceID_;
		public uint conditionIncreaseFixid_;
		public uint conditionDecreaseFixid_;
		public uint conditionForceMaxFixid_;
		public uint conditionForceOffFixid_;
		public uint teritoryFixId_;
		public float territoryRadius_;
		public float territoryHeight_;
		public float battleAreaMargin_;
		public string bgmFilePath_;
		public float genrateAngleFromCameraBehind_;
		public float generateDistanceFromCameraMin_;
		public float generateDistanceFromCameraMax_;
		public float generateHeightFromGround_;
		public float autoDeleteDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPopReinforcement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Reinforcement.SequenceActionPopReinforcement", 0, Black.Sequence.Action.Level.Reinforcement.SequenceActionPopReinforcement.ObjectType, null, properties, 0, 912);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Reinforcement.SequenceActionPopReinforcement", base.GetFieldProperties(), 1400295520, 1988407484);
            return fieldProperties;
        }

		
    }
}