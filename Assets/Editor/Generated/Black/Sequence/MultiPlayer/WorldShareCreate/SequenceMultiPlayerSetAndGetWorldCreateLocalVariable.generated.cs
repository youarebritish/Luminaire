using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer.WorldShareCreate
{
    public partial class SequenceMultiPlayerSetAndGetWorldCreateLocalVariable : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inAdd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inClear_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inRemove_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inFixidValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inRemoveIndex_;
		public int variableName_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outListValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerSetAndGetWorldCreateLocalVariable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSetAndGetWorldCreateLocalVariable", 0, Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSetAndGetWorldCreateLocalVariable.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSetAndGetWorldCreateLocalVariable", base.GetFieldProperties(), 1390886970, 989582302);
            
			
			
			return fieldProperties;
        }

		
    }
}