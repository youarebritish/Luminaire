using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionCheckUGC : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin enabled_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin disabled_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public bool attemptDetaile_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCheckUGC();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionCheckUGC", 0, Black.Sequence.Action.System.SequenceActionCheckUGC.ObjectType, null, properties, 0, 728);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionCheckUGC", base.GetFieldProperties(), -837544191, 1713121527);
            
			
			
			return fieldProperties;
        }

		
    }
}