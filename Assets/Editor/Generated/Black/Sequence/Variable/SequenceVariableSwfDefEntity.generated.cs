using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableSwfDefEntity : Black.Sequence.Variable.SequenceVariableSwfConnector
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValue_;
		public SQEX.Ebony.Framework.Entity.Entity entityPointer_;
		public bool isSetTextFieldConfig_;
		public bool isSetLabelSound_;
		public IList<Black.Entity.Data.Menu.SwfTextFieldConfigArrayItem> textFiledConfigList_;
		public IList<Black.Entity.Data.Menu.SwfLabelAccessoryArrayItem> labelAccessoryList_;
		public IList<Black.Entity.Data.Menu.SwfStringArrayItem> nameList_;
		public IList<Black.Entity.Data.Menu.SwfFixidArrayItem> fixidList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableSwfDefEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableSwfDefEntity", 0, Black.Sequence.Variable.SequenceVariableSwfDefEntity.ObjectType, null, properties, 0, 3624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableSwfDefEntity", base.GetFieldProperties(), -101153703, -981291477);
            return fieldProperties;
        }

		
    }
}