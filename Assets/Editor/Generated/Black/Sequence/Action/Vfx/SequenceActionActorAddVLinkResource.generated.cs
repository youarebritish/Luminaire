using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vfx
{
    public partial class SequenceActionActorAddVLinkResource : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin addPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin removePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outAddPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outRemovePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vlinkResourcePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public bool bRemoveWhenUnload_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAddVLinkResource();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vfx.SequenceActionActorAddVLinkResource", 0, Black.Sequence.Action.Vfx.SequenceActionActorAddVLinkResource.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vfx.SequenceActionActorAddVLinkResource", base.GetFieldProperties(), -1595374710, -1503237917);
            return fieldProperties;
        }

		
    }
}