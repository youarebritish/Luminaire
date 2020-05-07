using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.MiniGame
{
    public partial class SequenceActionCarnivalGameRecord : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin set_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int type_;
		public int level_;
		public bool useTool_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin scoreOut3_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin scoreOut2_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin scoreOut1_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin millisecondOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin secondOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin minuteOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin scoreIn_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCarnivalGameRecord();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.MiniGame.SequenceActionCarnivalGameRecord", 0, Black.Sequence.Action.MiniGame.SequenceActionCarnivalGameRecord.ObjectType, null, properties, 0, 1000);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.MiniGame.SequenceActionCarnivalGameRecord", base.GetFieldProperties(), 30283874, -93550211);
            return fieldProperties;
        }

		
    }
}