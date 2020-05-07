using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Bumper
{
    public partial class SequenceActionBumperStart : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin m_in;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_finished;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_completed;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin m_coins;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin m_score;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin m_treasures;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_menuOpen;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_menuClosed;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin m_tableActor;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin m_close;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin m_lucky;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_quit;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin m_quitAccept;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin m_quitCancel;
		public float m_fadeInTime;
		public float m_fadeOutTime;
		public float m_chanceModifier;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionBumperStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Bumper.SequenceActionBumperStart", 0, Black.Sequence.Action.Minigame.Bumper.SequenceActionBumperStart.ObjectType, null, properties, 0, 1912);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Bumper.SequenceActionBumperStart", base.GetFieldProperties(), -1492506076, 98225638);
            return fieldProperties;
        }

		
    }
}