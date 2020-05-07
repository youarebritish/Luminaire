using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.AI
{
    public partial class SequenceChangeNavigationCenter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceChangeNavigationCenter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.AI.SequenceChangeNavigationCenter", 0, Black.Sequence.AI.SequenceChangeNavigationCenter.ObjectType, null, properties, 0, 456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.AI.SequenceChangeNavigationCenter", base.GetFieldProperties(), -1451423288, -392786210);
            return fieldProperties;
        }

		
    }
}