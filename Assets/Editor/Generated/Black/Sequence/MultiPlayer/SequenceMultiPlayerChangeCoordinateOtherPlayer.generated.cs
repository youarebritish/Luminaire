using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerChangeCoordinateOtherPlayer : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin requestIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startSyncIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotationIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin requestFinishedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin syncFinishedOPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerChangeCoordinateOtherPlayer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerChangeCoordinateOtherPlayer", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerChangeCoordinateOtherPlayer.ObjectType, null, properties, 0, 928);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerChangeCoordinateOtherPlayer", base.GetFieldProperties(), -1664244840, -1231101207);
            return fieldProperties;
        }

		
    }
}