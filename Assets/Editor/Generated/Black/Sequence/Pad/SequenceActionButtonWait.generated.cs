using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Pad
{
    public partial class SequenceActionButtonWait : Black.Sequence.Pad.SequenceActionButtonStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin action_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin button_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int actionProperty_;
		public int buttonProperty_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionButtonWait();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Pad.SequenceActionButtonWait", 0, Black.Sequence.Pad.SequenceActionButtonWait.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Pad.SequenceActionButtonWait", base.GetFieldProperties(), -326143349, -1284297981);
            
			
			
			return fieldProperties;
        }

		
    }
}