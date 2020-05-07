using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera.PointNode
{
    public partial class SequenceActionCameraAttach : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pointNodeCamera_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActor_;
		public bool isAttach_;
		public UnityEngine.Vector4 offset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraAttach();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.PointNode.SequenceActionCameraAttach", 0, Black.Sequence.Action.Camera.PointNode.SequenceActionCameraAttach.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.PointNode.SequenceActionCameraAttach", base.GetFieldProperties(), 1094955004, 435355192);
            
			
			
			return fieldProperties;
        }

		
    }
}