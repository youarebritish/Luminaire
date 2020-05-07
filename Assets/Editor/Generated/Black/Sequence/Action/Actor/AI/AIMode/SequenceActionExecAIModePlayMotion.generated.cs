using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModePlayMotion : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aniPathLoopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aniPathStartPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin facialAniPathLoopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin facialAniPathStartPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public string aniPathStart_;
		public string aniPathLoop_;
		public string facialAniPathStart_;
		public string facialAniPathLoop_;
		public float loopTime_;
		public float startBlendDuration_;
		public float loopBlendDuration_;
		public bool disableLookAtIK;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModePlayMotion();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModePlayMotion", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModePlayMotion.ObjectType, null, properties, 0, 2024);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModePlayMotion", base.GetFieldProperties(), 347331577, 435579830);
            
			
			
			return fieldProperties;
        }

		
    }
}