using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecBuddyMode : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target1_;
		public uint aiSubModeId_;
		public int type_;
		public float floatValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecBuddyMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecBuddyMode", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecBuddyMode.ObjectType, null, properties, 0, 1448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecBuddyMode", base.GetFieldProperties(), 782913758, 329606152);
            return fieldProperties;
        }

		
    }
}