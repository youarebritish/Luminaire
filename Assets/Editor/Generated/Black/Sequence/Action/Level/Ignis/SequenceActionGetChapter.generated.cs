using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Ignis
{
    public partial class SequenceActionGetChapter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int chapter_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin chapter_pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin equal_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notEqual_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetChapter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Ignis.SequenceActionGetChapter", 0, Black.Sequence.Action.Level.Ignis.SequenceActionGetChapter.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Ignis.SequenceActionGetChapter", base.GetFieldProperties(), -2244667, -203732411);
            
			
			
			return fieldProperties;
        }

		
    }
}