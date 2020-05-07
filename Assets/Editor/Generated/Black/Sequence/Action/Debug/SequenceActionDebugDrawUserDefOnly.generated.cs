using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugDrawUserDefOnly : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin1_;
		public int drawType_;
		public int positionType_;
		public int offsetType_;
		public UnityEngine.Color color_;
		public bool bIsFillDraw_;
		public float validTime_;
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 offset_;
		public float radius_;
		public int textStyle_;
		public string text_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugDrawUserDefOnly();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugDrawUserDefOnly", 0, Black.Sequence.Action.Debug.SequenceActionDebugDrawUserDefOnly.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugDrawUserDefOnly", base.GetFieldProperties(), 2066560505, 1077379249);
            return fieldProperties;
        }

		
    }
}