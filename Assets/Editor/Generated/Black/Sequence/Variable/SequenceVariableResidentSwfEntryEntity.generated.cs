using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableResidentSwfEntryEntity : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValue_;
		public uint entitySearchLabelId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputEntity_;
		public string swfEntryPackagePath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableResidentSwfEntryEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableResidentSwfEntryEntity", 0, Black.Sequence.Variable.SequenceVariableResidentSwfEntryEntity.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableResidentSwfEntryEntity", base.GetFieldProperties(), 317731568, -1884778050);
            
			
			
			return fieldProperties;
        }

		
    }
}