using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionSoftwareKeyboard : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin inputTextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputDefaultPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputLimitPin_;
		public uint titleId_;
		public uint descriptionId_;
		public uint defaultId_;
		public bool allowEmpty_;
		public int keyboardType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSoftwareKeyboard();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionSoftwareKeyboard", 0, Black.Sequence.Action.System.SequenceActionSoftwareKeyboard.ObjectType, null, properties, 0, 960);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionSoftwareKeyboard", base.GetFieldProperties(), 1535937367, 73626891);
            
			
			
			return fieldProperties;
        }

		
    }
}