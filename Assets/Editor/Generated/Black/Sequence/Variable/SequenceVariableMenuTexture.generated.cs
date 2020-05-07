using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableMenuTexture : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int textureCategory_;
		public int intParam_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin texturePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isPhotoReadyPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableMenuTexture();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableMenuTexture", 0, Black.Sequence.Variable.SequenceVariableMenuTexture.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableMenuTexture", base.GetFieldProperties(), 1893598741, 1112635716);
            
			
			
			return fieldProperties;
        }

		
    }
}