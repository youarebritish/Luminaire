using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorGetSceneType : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputSceneID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetSceneType();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorGetSceneType", 0, Black.Sequence.Actor.SequenceActionActorGetSceneType.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorGetSceneType", base.GetFieldProperties(), 1598195814, 1030253724);
            return fieldProperties;
        }

		
    }
}