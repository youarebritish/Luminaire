using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.EventScript
{
    public partial class SequenceActionEventScriptPostFaceToFaceFixid : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public uint f2fSignalId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEventScriptPostFaceToFaceFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.EventScript.SequenceActionEventScriptPostFaceToFaceFixid", 0, Black.Sequence.Action.EventScript.SequenceActionEventScriptPostFaceToFaceFixid.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.EventScript.SequenceActionEventScriptPostFaceToFaceFixid", base.GetFieldProperties(), -741373633, -961046506);
            return fieldProperties;
        }

		
    }
}