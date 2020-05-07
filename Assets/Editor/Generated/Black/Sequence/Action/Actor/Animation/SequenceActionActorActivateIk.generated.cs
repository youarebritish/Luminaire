using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Animation
{
    public partial class SequenceActionActorActivateIk : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reset_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool isReset_;
		public bool activate_;
		public int ikType_;
		public uint tuningSet_;
		public float blendTime_;
		public uint targetBone_;
		public int lookAtSlot_;
		public int aimAtSlot_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorActivateIk();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Animation.SequenceActionActorActivateIk", 0, Black.Sequence.Action.Actor.Animation.SequenceActionActorActivateIk.ObjectType, null, properties, 0, 1104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Animation.SequenceActionActorActivateIk", base.GetFieldProperties(), -489164602, 2140862402);
            return fieldProperties;
        }

		
    }
}