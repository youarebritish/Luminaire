using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionCheckAppContents : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin enabled_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin disabled_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin none_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin enabledMany_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCheckAppContents();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionCheckAppContents", 0, Black.Sequence.Action.System.SequenceActionCheckAppContents.ObjectType, null, properties, 0, 824);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionCheckAppContents", base.GetFieldProperties(), 626104587, 1059964438);
            return fieldProperties;
        }

		
    }
}