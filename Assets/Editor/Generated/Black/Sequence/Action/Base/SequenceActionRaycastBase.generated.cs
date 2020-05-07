using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Base
{
    public partial class SequenceActionRaycastBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin startVectPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin endVectPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueHitActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueHitVector_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueHitNormal_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueHitDistance_;
		public UnityEngine.Vector4 startPosition_;
		public UnityEngine.Vector4 endPosition_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionRaycastBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Base.SequenceActionRaycastBase", 0, Black.Sequence.Action.Base.SequenceActionRaycastBase.ObjectType, null, properties, 0, 1008);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Base.SequenceActionRaycastBase", base.GetFieldProperties(), 103817465, -63470716);
            return fieldProperties;
        }

		
    }
}