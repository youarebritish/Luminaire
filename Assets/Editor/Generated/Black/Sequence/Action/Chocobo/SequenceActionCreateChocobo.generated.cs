using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Chocobo
{
    public partial class SequenceActionCreateChocobo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin changeNocts_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin noctChocobo_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin gladioChocobo_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin promptChocobo_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin ignisChocobo_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin guestChocobo_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCreateChocobo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Chocobo.SequenceActionCreateChocobo", 0, Black.Sequence.Action.Chocobo.SequenceActionCreateChocobo.ObjectType, null, properties, 0, 1088);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Chocobo.SequenceActionCreateChocobo", base.GetFieldProperties(), 9322691, -1247669251);
            
			
			
			return fieldProperties;
        }

		
    }
}