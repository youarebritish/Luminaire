using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.System
{
    public partial class SequenceActionGetClearFlagDLC : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin bool_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin exist_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notExist_;
		public int target_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetClearFlagDLC();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.System.SequenceActionGetClearFlagDLC", 0, Black.Sequence.Action.Level.System.SequenceActionGetClearFlagDLC.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.System.SequenceActionGetClearFlagDLC", base.GetFieldProperties(), -620132859, 300514673);
            return fieldProperties;
        }

		
    }
}