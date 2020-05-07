using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Physics
{
    public partial class SequenceActionActorBonamikWindScale : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupsPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorsPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float windScale_;
		public int blendedFrames;
		public int selectGroup_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBonamikWindScale();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikWindScale", 0, Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikWindScale.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikWindScale", base.GetFieldProperties(), 654766565, 1521216381);
            return fieldProperties;
        }

		
    }
}