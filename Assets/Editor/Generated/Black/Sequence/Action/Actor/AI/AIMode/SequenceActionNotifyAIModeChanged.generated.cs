using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionNotifyAIModeChanged : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionGetAIModeInfo
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin enabled_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin disabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionNotifyAIModeChanged();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionNotifyAIModeChanged", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionNotifyAIModeChanged.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionNotifyAIModeChanged", base.GetFieldProperties(), -1086898912, 2084259072);
            return fieldProperties;
        }

		
    }
}