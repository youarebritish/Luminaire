using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionDisplayBattleQuestInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin opened_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public float dispTime_;
		public int messageSpecificationType_;
		public uint titleFixId_;
		public uint infoFixId_;
		public string titleString_;
		public string infoString_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDisplayBattleQuestInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionDisplayBattleQuestInfo", 0, Black.Sequence.Action.Menu.SequenceActionDisplayBattleQuestInfo.ObjectType, null, properties, 0, 704);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionDisplayBattleQuestInfo", base.GetFieldProperties(), 714114674, -172340020);
            return fieldProperties;
        }

		
    }
}