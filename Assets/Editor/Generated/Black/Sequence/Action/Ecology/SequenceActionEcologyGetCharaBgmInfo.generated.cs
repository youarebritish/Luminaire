using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionEcologyGetCharaBgmInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueCharacterId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueCharaEntryPath_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueLoadSuccess_;
		public uint teritoryCharacterId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueOverwriteParamId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEcologyGetCharaBgmInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionEcologyGetCharaBgmInfo", 0, Black.Sequence.Action.Ecology.SequenceActionEcologyGetCharaBgmInfo.ObjectType, null, properties, 0, 872);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionEcologyGetCharaBgmInfo", base.GetFieldProperties(), 1168449447, -1612041332);
            return fieldProperties;
        }

		
    }
}