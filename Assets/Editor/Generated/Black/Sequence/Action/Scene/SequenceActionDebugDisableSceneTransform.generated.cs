using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Scene
{
    public partial class SequenceActionDebugDisableSceneTransform : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin get_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changed_;
		public bool isEnable_;
		public bool isSendSignalToAll_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugDisableSceneTransform();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Scene.SequenceActionDebugDisableSceneTransform", 0, Black.Sequence.Action.Scene.SequenceActionDebugDisableSceneTransform.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Scene.SequenceActionDebugDisableSceneTransform", base.GetFieldProperties(), -491691313, -612461632);
            return fieldProperties;
        }

		
    }
}