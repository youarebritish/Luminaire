using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionAttachSwfEntity : Black.Sequence.Action.Menu.SequenceActionSwfEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin self_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin base_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAttachSwfEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionAttachSwfEntity", 0, Black.Sequence.Action.Menu.SequenceActionAttachSwfEntity.ObjectType, null, properties, 0, 648);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionAttachSwfEntity", base.GetFieldProperties(), 1112724876, 1421275834);
            return fieldProperties;
        }

		
    }
}