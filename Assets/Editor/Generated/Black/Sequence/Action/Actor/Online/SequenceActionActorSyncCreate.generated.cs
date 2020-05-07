using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Online
{
    public partial class SequenceActionActorSyncCreate : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin list_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin areaIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin uniqueIdPin_;
		public uint uniqueId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSyncCreate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Online.SequenceActionActorSyncCreate", 0, Black.Sequence.Action.Actor.Online.SequenceActionActorSyncCreate.ObjectType, null, properties, 0, 1032);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Online.SequenceActionActorSyncCreate", base.GetFieldProperties(), -2124469281, 2084849295);
            return fieldProperties;
        }

		
    }
}