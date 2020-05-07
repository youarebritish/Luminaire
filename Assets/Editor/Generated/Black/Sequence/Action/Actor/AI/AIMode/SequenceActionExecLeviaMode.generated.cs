using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecLeviaMode : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aiSubModeIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveTpsQueryIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin attackTpsQueryIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin searchLabelIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin basePointIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin basePositionIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin baseRadiusIPin_;
		public uint aiSubModeId_;
		public uint moveTpsQueryId_;
		public uint attackTpsQueryId_;
		public uint searchLabelId_;
		public float baseRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecLeviaMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaMode", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaMode.ObjectType, null, properties, 0, 1904);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaMode", base.GetFieldProperties(), 698308602, -936788191);
            
			
			
			return fieldProperties;
        }

		
    }
}