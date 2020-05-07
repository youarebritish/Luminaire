using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorRotationTarget : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueTarget_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueOwner_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueOffset_;
		public bool spendUpdate_;
		public bool onlyYAxis_;
		public bool ownerUpdate_;
		public float timeOut_;
		public float maxRotateAngle_;
		public float targetAngle_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorRotationTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorRotationTarget", 0, Black.Sequence.Actor.SequenceActionActorRotationTarget.ObjectType, null, properties, 0, 816);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorRotationTarget", base.GetFieldProperties(), -1580077364, -439607802);
            return fieldProperties;
        }

		
    }
}