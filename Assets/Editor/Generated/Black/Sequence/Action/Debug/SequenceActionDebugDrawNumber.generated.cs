using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugDrawNumber : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public string path0_;
		public string path1_;
		public string path2_;
		public string path3_;
		public string path4_;
		public string path5_;
		public string path6_;
		public string path7_;
		public string path8_;
		public string path9_;
		public float intervalX_;
		public float posX_;
		public float posY_;
		public float scale_;
		public float fadeInTime_;
		public float fadeOutTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin posXPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin posYPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin scalePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valuePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugDrawNumber();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugDrawNumber", 0, Black.Sequence.Action.Debug.SequenceActionDebugDrawNumber.ObjectType, null, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugDrawNumber", base.GetFieldProperties(), 2133385069, 739686483);
            return fieldProperties;
        }

		
    }
}