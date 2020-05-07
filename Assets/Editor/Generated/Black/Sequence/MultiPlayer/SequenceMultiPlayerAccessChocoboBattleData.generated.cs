using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerAccessChocoboBattleData : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inSet_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int mode_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo1set_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo2set_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo3set_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocobo4set_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enemySet_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin battleClassId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chocobo1type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chocobo2type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chocobo3type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chocobo4type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy1class_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy1ow_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy2class_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy2ow_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy3class_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy3ow_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy4class_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enemy4ow_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin reward1stPower_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin reward1stGil_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin reward1stItem_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin reward1stItemNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rewardItem_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rewardItemNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerAccessChocoboBattleData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboBattleData", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboBattleData.ObjectType, null, properties, 0, 2680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboBattleData", base.GetFieldProperties(), 474444024, -1558396104);
            return fieldProperties;
        }

		
    }
}