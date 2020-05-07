using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorTalkArea : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin createIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin destroyIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin centralTalkActorIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin talkActorIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin areaPositionIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin areaRadiusIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOPin_;
		public int areaType_;
		public bool isFollowCentralTalkActor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorTalkArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorTalkArea", 0, Black.Sequence.Action.Actor.SequenceActionActorTalkArea.ObjectType, null, properties, 0, 856);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorTalkArea", base.GetFieldProperties(), 956906931, 1160716848);
            return fieldProperties;
        }

		
    }
}