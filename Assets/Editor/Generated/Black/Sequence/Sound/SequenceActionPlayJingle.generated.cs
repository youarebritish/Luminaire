using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Sound
{
    public partial class SequenceActionPlayJingle : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin play_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public string idxFilePath_;
		public float fadeIn_;
		public float fadeOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayJingle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Sound.SequenceActionPlayJingle", 0, Black.Sequence.Sound.SequenceActionPlayJingle.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Sound.SequenceActionPlayJingle", base.GetFieldProperties(), 445613590, 158749608);
            
			
			
			return fieldProperties;
        }

		
    }
}