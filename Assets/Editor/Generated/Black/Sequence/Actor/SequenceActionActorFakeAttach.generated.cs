using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorFakeAttach : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin self_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin parent_;
		public uint jointSelfElementId_;
		public uint jointParentElementId_;
		public uint jointSelfElementId2_;
		public uint jointParentElementId2_;
		public uint jointSelfElementId3_;
		public uint jointParentElementId3_;
		public bool isDetach;
		public bool localRotationFlag;
		public UnityEngine.Vector4 offsetPosition;
		public UnityEngine.Vector4 offsetRotation;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorFakeAttach();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorFakeAttach", 0, Black.Sequence.Actor.SequenceActionActorFakeAttach.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorFakeAttach", base.GetFieldProperties(), 954327611, 334506469);
            
			
			
			return fieldProperties;
        }

		
    }
}