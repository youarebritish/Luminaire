using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionCheckPlatform : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin all_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin win_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin ps4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin xone_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin ps4_xone_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin high_spec_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin not_high_spec_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCheckPlatform();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionCheckPlatform", 0, Black.Sequence.Action.System.SequenceActionCheckPlatform.ObjectType, null, properties, 0, 944);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionCheckPlatform", base.GetFieldProperties(), 1729455691, 997279441);
            
			
			
			return fieldProperties;
        }

		
    }
}