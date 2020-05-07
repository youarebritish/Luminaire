using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorGetModelJointInfo : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin jointIdPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputDirection_;
		public bool isNeedTransformLocalPosFromParentPackage_;
		public bool localFlag_;
		public uint jointId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetModelJointInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorGetModelJointInfo", 0, Black.Sequence.Actor.SequenceActionActorGetModelJointInfo.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorGetModelJointInfo", base.GetFieldProperties(), -1354368741, -198915780);
            
			
			
			return fieldProperties;
        }

		
    }
}