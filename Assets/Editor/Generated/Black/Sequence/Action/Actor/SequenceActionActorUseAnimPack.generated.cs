using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorUseAnimPack : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin deactivate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin load_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin unload_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin activated_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin deactivated_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin loaded_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public bool isAutoLoad_;
		public string sourcePath_;
		public bool stopCurrentAnim_;
		public int priorityType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorUseAnimPack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorUseAnimPack", 0, Black.Sequence.Action.Actor.SequenceActionActorUseAnimPack.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorUseAnimPack", base.GetFieldProperties(), 2059803967, -1683862932);
            return fieldProperties;
        }

		
    }
}