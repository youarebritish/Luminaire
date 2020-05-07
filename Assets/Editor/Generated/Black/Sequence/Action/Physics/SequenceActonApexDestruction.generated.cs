using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Physics
{
    public partial class SequenceActonApexDestruction : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inDirection_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPower_;
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 direction_;
		public float power_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActonApexDestruction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Physics.SequenceActonApexDestruction", 0, Black.Sequence.Action.Physics.SequenceActonApexDestruction.ObjectType, null, properties, 0, 960);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Physics.SequenceActonApexDestruction", base.GetFieldProperties(), -449481306, 817252273);
            return fieldProperties;
        }

		
    }
}