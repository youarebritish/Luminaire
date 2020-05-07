using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionCreateAvoidArea : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin release_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetObject_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightIn_;
		public float overwriteHeight_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin radiusIn_;
		public float overwriteRadius_;
		public UnityEngine.Vector4 offset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succeeded_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public bool isKillActorInAvoidArea_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCreateAvoidArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionCreateAvoidArea", 0, Black.Sequence.Action.Level.SequenceActionCreateAvoidArea.ObjectType, null, properties, 0, 1072);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionCreateAvoidArea", base.GetFieldProperties(), -1688314260, 164482235);
            return fieldProperties;
        }

		
    }
}