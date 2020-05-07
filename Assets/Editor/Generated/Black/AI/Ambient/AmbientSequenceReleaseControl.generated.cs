using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientSequenceReleaseControl : Black.AI.Ambient.AmbientSequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientSequenceReleaseControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientSequenceReleaseControl", 0, Black.AI.Ambient.AmbientSequenceReleaseControl.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientSequenceReleaseControl", base.GetFieldProperties(), -1758189817, 1135500255);
            return fieldProperties;
        }

		
    }
}