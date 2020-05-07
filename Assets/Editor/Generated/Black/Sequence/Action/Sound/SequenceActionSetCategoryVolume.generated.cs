using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Sound
{
    public partial class SequenceActionSetCategoryVolume : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin resume_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin suspend_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int menuControl_;
		public float fadeSec_;
		public float volume_;
		public string category_;
		public int directIndex_;
		public bool propagateBgm_;
		public bool propagateVoice_;
		public bool propagateNoCommonSE_;
		public bool ignoreCategory_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetCategoryVolume();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Sound.SequenceActionSetCategoryVolume", 0, Black.Sequence.Action.Sound.SequenceActionSetCategoryVolume.ObjectType, null, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Sound.SequenceActionSetCategoryVolume", base.GetFieldProperties(), -443821439, -1212150112);
            
			
			
			return fieldProperties;
        }

		
    }
}